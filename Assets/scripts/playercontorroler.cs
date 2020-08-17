using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class playercontorroler : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
    public int jumpforce;
    public Transform groundpoint;
    public LayerMask groundlayer;
    public bool grounded; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapPoint(groundpoint.position, groundlayer);
            }
    // Update is called once per frame
    void Update()
    { if(grounded && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("jump");
            rb.AddForce(Vector2.up * jumpforce);

        }
        anim.SetFloat("yVelocity", rb.velocity.y);
        anim.SetBool("grounded", grounded);
    }
    public void gameover() { Destroy(gameObject); }
}
