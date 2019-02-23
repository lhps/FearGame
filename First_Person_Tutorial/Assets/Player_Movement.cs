﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = -9.8f;
    private CharacterController _charCont;

    // Start is called before the first frame update
    void Start()
    {
        _charCont = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX,0,deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed); //limits the max speed of the  player

        movement.y = gravity;
        movement *= Time.deltaTime; // this ensures that speed the player moves does not change on frame rate
        movement = transform.TransformDirection(movement);
        _charCont.Move(movement);
    }
}
