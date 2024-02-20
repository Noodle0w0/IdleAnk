using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    public GameObject randomCoin;
    bool coin_spawn = true;

    void Start()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        while (coin_spawn == true)
        {
            Instantiate(randomCoin, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
