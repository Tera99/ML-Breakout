﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float paddleSpeed = 20f;
    public float xPosLimit = 9.5f;
    public float xNegLimit = -9.5f;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get input from player
        horizontalInput = Input.GetAxis("Horizontal");

        // move paddle based on user input and paddleSpeed
        transform.position += new Vector3(horizontalInput * Time.deltaTime * paddleSpeed, 0f, 0f);

        // restrict paddle movement to positive and negative limits
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xNegLimit, xPosLimit), transform.position.y, transform.position.z);
    }
}
