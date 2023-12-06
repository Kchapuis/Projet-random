using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private bool isOpen = false;
    [SerializeField] private List<Key> keyToOpen;
}
