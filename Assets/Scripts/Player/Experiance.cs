using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Experiance : MonoBehaviour
{
    public Image expImg;
    public Text levelText;
    public int currentLwl;

    [HideInInspector]
    public float currentExp;
    public float expToNextLevel;
    public static Experiance instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    void Start()
    {
        expImg.fillAmount = currentExp / expToNextLevel;
        currentLwl = 1;
        levelText.text=currentLwl.ToString();
    }

 
    void Update()
    {
        expImg.fillAmount = currentExp / expToNextLevel;
        levelText.text = currentLwl.ToString();
    }

    public void expMod(float experiance)
    {
        currentExp += experiance;
        expImg.fillAmount = currentExp / expToNextLevel;
        if (currentExp >= expToNextLevel) 
        {
            expToNextLevel *= 2;
            currentExp = 0;
            currentLwl++;
            levelText.text = currentLwl.ToString();
            PlayerHealth.instance.maxHealth += 20;
            PlayerHealth.instance.currentHealth += 20;
        }
    }
}
