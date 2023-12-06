using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Porte : MonoBehaviour
{
    public int dir;
    public Room RoomIN;
    public Room RoomOUT;
    public bool ActualRoom;
    CameraManager test;
    // Update is called once per frame
    void Start()
    {
        ActualRoom = true;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        test = Camera.main.GetComponent<CameraManager>();
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
