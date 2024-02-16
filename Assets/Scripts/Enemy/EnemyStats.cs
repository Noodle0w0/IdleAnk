using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float maxHealt;
    private float currentHealth;
    public float timer;
    
    HitEffect effect;
    public GameObject slimeDeath;
    
  
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
        }
    }

    IEnumerator BackToNormal()
    {
        yield return new WaitForSeconds(timer);
        GetComponent<SpriteRenderer>().material = effect.original;
    }
}
