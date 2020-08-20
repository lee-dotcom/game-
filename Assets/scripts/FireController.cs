using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public int moveVel = 5;

    Transform startPosition;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x != gamemanager.instance.endPosMovHazard.position.x)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(gamemanager.instance.endPosMovHazard.position.x, transform.position.y, transform.position.z), Time.deltaTime * moveVel);
        }
        else
        {
            startPosition = gamemanager.instance.spawnPosMovHazard[Random.Range(0, gamemanager.instance.spawnPosMovHazard.Length)];
            transform.position = startPosition.position;
        }


    }
}
