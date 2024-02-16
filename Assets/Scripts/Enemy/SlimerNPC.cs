using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimerNPC : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    SpriteRenderer spr;

    public int enemy_sprite;
    public Sprite slime;

    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        enemy_sprite = Random.Range(1, 1);

        

        switch(enemy_sprite)
        {
            case 1:
                spr.sprite = slime;
                break;
        }
    }

    
    void Update()
    {
        rb.velocity = new Vector3(rb.velocity.x+2,rb.velocity.y,0);
    }
}
