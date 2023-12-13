using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private bool isOpen = false;
    [SerializeField] private List<Key> keyToOpen;

    private Animator animator;

    public List<Key> KeyToOpen { get => keyToOpen; set => keyToOpen = value; }

    public void Open()
    {
        if (isOpen)
            return;

        isOpen = true;
        animator = GetComponent<Animator>();
        animator.SetBool("IsOpen", true);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
