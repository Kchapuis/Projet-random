using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private Key keyDropped;
    [SerializeField] private bool isOpen = false;
    public Key KeyDropped { get => keyDropped; set => keyDropped = value; }
    public bool IsOpen { get => isOpen; set => isOpen = value; }

    private void Update()
    {
        if (IsOpen)
        {
            GetComponent<Animator>().SetBool("IsOpen", true);
        }
    }
}
