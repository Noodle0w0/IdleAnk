using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinController : MonoBehaviour
{
    private static int coinCount = 0;
    public TMP_Text coinText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            coinCount++;
            coinText.text = "Coin: " + coinCount.ToString();
        }
    }
}
