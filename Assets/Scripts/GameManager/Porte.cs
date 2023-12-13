using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Porte : MonoBehaviour
{
    public int dir;
    public GameObject RoomIN;
    public GameObject RoomOUT;
    public bool ActualRoom;
    CameraManager test;
    // Update is called once per frame
    void Start()
    {
        ActualRoom = true;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col is BoxCollider2D)
        {
            test = Camera.main.GetComponent<CameraManager>();
            Debug.Log("test");
            ActualRoom = !ActualRoom;
            if(ActualRoom)
            {
                test.ChangeFocusRoom(RoomIN);
            }
            else
            {
                test.ChangeFocusRoom(RoomOUT);
            }
        }
        
    }
}
