using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private int keyHole;

    [SerializeField] private Key keyDropped;

    public int KeyHole { get => keyHole; set => keyHole = value; }
    public Key KeyDropped { get => keyDropped; set => keyDropped = value; }
}
