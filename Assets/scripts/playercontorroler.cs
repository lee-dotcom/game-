using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class playercontorroler : MonoBehaviour
{
     Animator anim;
     Rigidbody2D rb;
    public int jumpforce;
    public Transform groundpoint;
    public LayerMask groundlayer;
     bool grounded;
    public GameObject deatheffect;
    public GameObject gameOver;
    



 
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();



        rb = GetComponent<Rigidbody2D>();
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
    public void gameover() { 
        Instantiate(deatheffect, transform.position, Quaternion.identity);
        gamemanager.instance.cam.followplayer = false;
        gameOver.SetActive(true);
        gamemanager.instance.gameOver.SetActive(true);
        Destroy(gameObject);
    }
}
