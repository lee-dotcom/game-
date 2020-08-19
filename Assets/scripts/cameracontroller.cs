using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public playercontorroler player;
    public bool followplayer = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, player.transform.position.y, player.transform.position.z);
        transform.position = new Vector3(transform.position.x, gamemanager.instance.player.transform.position.y, transform.position.z);
    }
}
