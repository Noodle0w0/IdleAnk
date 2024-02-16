using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject randomEnemy;
    bool enemy_spawn = true;

    void Start()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        while (enemy_spawn==true)
        {
            Instantiate(randomEnemy,transform.position,Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }

}
