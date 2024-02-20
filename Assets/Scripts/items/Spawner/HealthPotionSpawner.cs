using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotionSpawner : MonoBehaviour
{
    public GameObject randomHealthPotion;
    bool HealthPotion_spawn = true;

    void Start()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        while (HealthPotion_spawn == true)
        {
            Instantiate(randomHealthPotion, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(15f);
        }
    }

}
