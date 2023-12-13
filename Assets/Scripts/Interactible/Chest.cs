using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private Key keyDropped;
    [SerializeField] private bool isOpen = false;
    [SerializeField] private int room;
    public Key KeyDropped { get => keyDropped; set => keyDropped = value; }
    public bool IsOpen { get => isOpen; set => isOpen = value; }
    public int Room { get => room; set => room = value; }


    private void Update()
    {
        if (IsOpen)
        {
            GetComponent<Animator>().SetBool("IsOpen", true);
        }
    }
}
