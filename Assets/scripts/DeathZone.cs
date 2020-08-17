using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{ public cameracontroller camera;
    public playercontorroler player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        camera.followplayer = false;
        player.gameover();
        
    }
}
