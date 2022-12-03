﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PYPlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        Vector3 destination = new Vector3(horizontal, 0, 0.5f);

        transform.Translate(destination * speed * Time.deltaTime);
    }
}
