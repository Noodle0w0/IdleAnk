using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinBank : MonoBehaviour
{
    public int bank;
    public static CoinBank instance;
    public Text bankText;

    private void Awake()
    {
        if (instance == null )
        {
            instance = this;
        }
            
    }

    void Start()
    {
        bankText.text = bank.ToString();
    }

    
    void Update()
    {
        
    }

    public void Money(int coinCollected)
    {
        bank += coinCollected;
        bankText.text= bank.ToString();
        
        
    }
}
