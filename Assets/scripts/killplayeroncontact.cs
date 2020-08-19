using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killplayeroncontact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player"))
        { collision.GetComponent<playercontorroler>().gameover(); }
    }
}
