using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScripts : MonoBehaviour
{
    public GameObject background;
    bool back_parallax = false;

    private void OnTriggerEnter2D(Collider2D touch)
    {
        if (touch.gameObject.tag == "Player" && back_parallax == false)
        {
            Vector3 spawn_location = new Vector3(transform.position.x + 17, transform.position.y, transform.position.z);
            Instantiate(background, spawn_location, Quaternion.identity);
            back_parallax = true;


        }

    }

    private void OnTriggerExit2D(Collider2D touch)
    {
        Destroy(this.gameObject, 50f);
    }
}
