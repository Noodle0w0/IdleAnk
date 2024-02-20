using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public Image HealthBar;
    public Image ExperianceBar;
    public static PlayerHealth instance;
    public Text HealthText;
 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        HealthText.text = currentHealth.ToString() + maxHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth >=maxHealth)
        {
            currentHealth = maxHealth;
        }
        HealthBar.fillAmount = currentHealth / maxHealth;
        HealthText.text = currentHealth.ToString() + maxHealth.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            currentHealth -= collision.GetComponent<EnemyStats>().damage;
            if(currentHealth <=0)
            {
                currentHealth = 0;
                Destroy(gameObject);
            }
        }
    }
}
