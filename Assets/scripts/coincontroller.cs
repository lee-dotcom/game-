using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coincontroller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gamemanager.instance.AddScore();

        Destroy(gameObject);
    }
}