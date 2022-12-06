using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerJostik : MonoBehaviour
{
    public Joystick joysticMove;
    public float speed = 1f;
    public Transform player;
    float x;
    float y;
    Vector3 move;

    private void FixedUpdate()
    {
        x = joysticMove.Horizontal + Input.GetAxis("Horizontal");
        y = joysticMove.Vertical + Input.GetAxis("Vertical");
        move = new Vector3(x, 0, y);
        transform.position = transform.position + (move * speed);

    }
}
