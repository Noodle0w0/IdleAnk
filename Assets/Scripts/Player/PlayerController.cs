using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;

    public Transform attackPoint;
    public float attackDistance;
    public LayerMask enemyLayers;

    private bool shouldMove = true;

    public float damage;
    public Text damageText;
    public float nextDamage;

    public int AtkGold;
    public Text AtkGoldText;
    public int AtkLevel;
    public Text AtkLevelText;

    public float attackRate = 2f;
    float nextAttack = 0;

    private float movementDirector;
    public float PlayerSpeed;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();


        nextDamage = damage + 10;
        damageText.text = damage.ToString() + "->" + nextDamage.ToString();
        AtkGoldText.text = AtkGold.ToString();
        AtkLevel = 1;
        AtkLevelText.text = AtkLevel.ToString();
    }


    void Update()
    {
        //if (Time.time > nextAttack)
       // {
       //     if (Input.GetKeyDown(KeyCode.Q))
       //     {
       //     }
       // }

        if (shouldMove)
        {
            transform.Translate(Vector2.right * PlayerSpeed * Time.deltaTime);
        }

        if (EnemyAttackStop())
        {
            Debug.Log("Engel var duruyor.");
           
            shouldMove = false;
            //nextAttack = Time.time + 1f / attackRate;
            Attack();
        }

        else
        {
          
         
                Debug.Log("Engel yok, karakter koþmaya devam ediyor.");
                shouldMove = true;
           


        }


        damageText.text = damage.ToString() + " -> " + nextDamage.ToString();
        AtkGoldText.text = AtkGold.ToString();
        AtkLevelText.text = AtkLevel.ToString();

    }
    private void FixedUpdate()
    {
        
        //Run();
       
        //Movement();
        
    }


    public void Attack()
    {
        
        anim.SetTrigger("Attack1");


        Collider2D[] hitememies = Physics2D.OverlapCircleAll(attackPoint.position, attackDistance, enemyLayers);

        foreach(Collider2D enemy in hitememies)
        {
            enemy.GetComponent<EnemyStats>().TakeDamage(damage);     
        }
    }

   


   // void Movement()
   //{
   //     movementDirector = Input.GetAxisRaw("Horizontal");
   //     rb.velocity = new Vector2(movementDirector*PlayerSpeed,rb.velocity.y);
   //     anim.SetFloat("RunSpeed", movementDirector * PlayerSpeed);
   //}




    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackDistance);
    }

    bool EnemyAttackStop()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 0.5f, enemyLayers);

        
        return hit.collider != null;
    }


    public void ButtonPressed()
    {
       if(AtkGold <= CoinBank.instance.bank)
        {
            CoinBank.instance.Money(-AtkGold);
            AtkGold += 20;
            nextDamage += 10;
            damage += 10;
            AtkLevel++;
        }
        
    }

}
