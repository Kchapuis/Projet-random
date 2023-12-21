using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private Inventory inventory;

    private void Awake()
    {
        inventory = gameObject.GetComponent<Inventory>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<Chest>() != null)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Chest chest = collision.GetComponent<Chest>();
                chest.GetComponent<Animator>().SetBool("IsOpen", true);
                if (chest.KeyDropped.keyName != "empty")
                {
                    inventory.AddKey(chest.KeyDropped);
                }
                Destroy(chest);
            }
        }
        if (collision.GetComponent<Door>() != null)
        {
            if (Input.GetKey(KeyCode.E))
            { 
                Door door = collision.GetComponent<Door>();
                if (door.KeyToOpen.Count == 0)
                {
                    door.Open();
                }
                else
                {
                    foreach (Key key in door.KeyToOpen)
                    {
                        if (inventory.HasKey(key))
                        {

                            inventory.RemoveKey(key);
                            door.Open();
                           
                        }
                    }
                }
            }
        }
    }
}
