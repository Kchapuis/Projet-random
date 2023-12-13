using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject RoomTofocus;
    private Vector3 _targetPosition;
    public float speed;
    void Start()
    {
        _targetPosition = transform.position;
    }
    public void ChangeFocusRoom(GameObject newRoomTofocus)
    {
        RoomTofocus = newRoomTofocus;
        
        _targetPosition = new Vector3(RoomTofocus.transform.position.x, RoomTofocus.transform.position.y, -10.0f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, speed * Time.deltaTime);
    }
}
