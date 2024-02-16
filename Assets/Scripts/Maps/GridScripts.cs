using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScripts : MonoBehaviour
{
    public GameObject grid;
    bool grid_parallax=false;

    private void OnTriggerEnter2D(Collider2D touch)
    {
        if(touch.gameObject.tag=="Player" && grid_parallax == false)
        {
            Vector3 spawn_location = new Vector3(transform.position.x + 105, transform.position.y, transform.position.z);
            Instantiate(grid, spawn_location, Quaternion.identity);
            grid_parallax = true;
            
            
        }
        
    }

    private void OnTriggerExit2D(Collider2D touch)
    {
        Destroy(this.gameObject, 100f);
    }

 

}
