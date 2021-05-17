using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 12f; //movement speed for the player/camera
    public float minX;
    public float maxX;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        Vector3 move = transform.right * x * Time.deltaTime;
        if ((transform.position.x + move.x) >= minX && (transform.position.x + move.x) <= maxX)
            transform.Translate(move);
    }
}
