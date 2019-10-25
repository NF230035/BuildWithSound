using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float speed;
    public Vector3 offset;
    public Vector3 offset2;
    public PlayerController pControl;

    void FixedUpdate()
    {
        //Testing to see if player is dead then switches camera accordingly
        if (pControl.firstRun == false)
        {
            Vector3 newPosition = player.position + offset2;
            Vector3 smoothposition = Vector3.Lerp(transform.position, newPosition, speed);
            transform.position = smoothposition;
            //transform.LookAt(player);
        }
        else
        {
        Vector3 newPosition = player.position + offset;
        Vector3 smoothposition = Vector3.Lerp(transform.position, newPosition, speed);
        transform.position = smoothposition;
        //transform.LookAt(player);
        }
    }
}
