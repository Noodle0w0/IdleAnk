using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScripts : MonoBehaviour
{
    public GameObject middle;
    bool middle_parallax = false;

    private void OnTriggerEnter2D(Collider2D touch)
    {
        if (touch.gameObject.tag == "Player" && middle_parallax == false)
        {
            Vector3 spawn_location = new Vector3(transform.position.x + 5, transform.position.y, transform.position.z);
            Instantiate(middle, spawn_location, Quaternion.identity);
            middle_parallax = true;


        }

    }

    private void OnTriggerExit2D(Collider2D touch)
    {
        Destroy(this.gameObject,50f);
    }
}
