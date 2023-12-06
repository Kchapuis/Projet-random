using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private int keyHole;

    [SerializeField] private int droppedKeyNumber;

    public int KeyHole { get => keyHole; set => keyHole = value; }
    public int DroppedKeyNumber { get => droppedKeyNumber; set => droppedKeyNumber = value; }
}
