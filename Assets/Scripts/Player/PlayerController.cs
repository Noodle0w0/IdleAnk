using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;

    public float PlayerSpeed;

    void Start()
    {
        
    }


    void Update()
    {
        
        Run();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }

    }

    void Run()
    {
        transform.Translate(Vector2.right * PlayerSpeed * Time.deltaTime);
    }

    public void Attack()
    {
        anim.SetTrigger("Attack1");
    }

 

}
