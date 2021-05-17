using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller; //controller for the move vector3
    public float speed = 12f; //movement speed for the player/camera
    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (Mathf.Abs(z) > 0.01f || Mathf.Abs(x) > 0.01f)
        {
            controller.Move(move * speed * Time.deltaTime);
        }
    }
}
