using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float maxHealt;
    public float newMaxHealt;
    private float currentHealth;
    public float timer;
    public float damage;
    HitEffect effect;
    public GameObject slimeDeath;
    public float expToGive;
    public static EnemyStats instance;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    void Start()
    {
        currentHealth = maxHealt;
        maxHealt = newMaxHealt;
        effect = GetComponent<HitEffect>();
    }

 
    void Update()
    {
        newMaxHealt += PlayerController.instance.gameTime * 2;
        
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        GetComponent<SpriteRenderer>().material = effect.white;
        StartCoroutine(BackToNormal());

        if (currentHealth <= 0) 
        { 
            currentHealth = 0;
            Instantiate(slimeDeath, transform.position,transform.rotation);
            Destroy(gameObject);
            Experiance.instance.expMod(expToGive);
        }
    }

    

    IEnumerator BackToNormal()
    {
        yield return new WaitForSeconds(timer);
        GetComponent<SpriteRenderer>().material = effect.original;
    }


}
