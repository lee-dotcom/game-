﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class playercontorroler : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
    public int jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    { if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("jump");
            rb.AddForce(Vector2.up * jumpforce);
        }
        
    }
}
