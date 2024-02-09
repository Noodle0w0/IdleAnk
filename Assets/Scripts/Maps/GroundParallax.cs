using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundParallax : MonoBehaviour
{
    // Start is called before the first frame update
    Material mat;
    public float distance;
    public Transform player;

    [Range(0f, 0.5f)]
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        distance += Time.deltaTime * speed;
        mat.SetTextureOffset("_MainTex", Vector2.right * distance);
        if (player != null)
        {
            PlayerFollow();
        }
    }

    void PlayerFollow()
    {
        transform.position = new Vector3(player.position.x + 1, player.position.y - 3, transform.position.z);
    }
}
