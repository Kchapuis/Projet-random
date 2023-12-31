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
    public bool HorizontalMod = false;
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
            if(HorizontalMod)
            {
                float distancetoRoomOUT = Vector3.Distance(RoomOUT.transform.position, col.transform.position);
                float distancetoRoomIN = Vector3.Distance(RoomIN.transform.position, col.transform.position);

                if(distancetoRoomOUT < distancetoRoomIN)
                {
                    test.ChangeFocusRoom(RoomIN);
                }
                else
                {
                    test.ChangeFocusRoom(RoomOUT);
                }
            }
            else
            {
               
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
}
