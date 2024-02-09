using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        if (player != null)
        {
            PlayerFollow();
        }
    }

    void PlayerFollow()
    {
        transform.position = new Vector3(player.position.x+1, player.position.y+1, transform.position.z);
    }
}
