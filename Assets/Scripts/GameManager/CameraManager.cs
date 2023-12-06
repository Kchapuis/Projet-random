using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Room RoomTofocus;
    void Start()
    {
        
    }
    public void ChangeFocusRoom(Room newRoomTofocus)
    {
        RoomTofocus = newRoomTofocus;
        transform.position = new Vector3(RoomTofocus.transform.position.x, RoomTofocus.transform.position.y, -10.0f);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
