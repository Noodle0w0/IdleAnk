using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float maxHealt;
    private float currentHealth;
    public float timer;
    public float damage;
    HitEffect effect;
    public GameObject slimeDeath;
    public float expToGive;
    
  
    void Start()
    {
        currentHealth = maxHealt;
        effect = GetComponent<HitEffect>();
    }

 
    void Update()
    {
        
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
