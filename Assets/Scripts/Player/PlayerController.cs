using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float PlayerSpeed = 5f;

    void Start()
    {
        
    }


    void Update()
    {
        Run();
    }

    void Run()
    {
        transform.Translate(Vector2.right * PlayerSpeed * Time.deltaTime);
    }
}
