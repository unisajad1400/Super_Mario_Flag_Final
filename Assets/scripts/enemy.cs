using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy : MonoBehaviour
{
    public GameObject marioPic;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    void OnCollisionEnter2D(Collision2D marioPic)
    {
        if(marioPic.gameObject.name.StartsWith("marioPic"))
        { 
            Destroy(marioPic.gameObject);
            Debug.Log("game over");
        }
    }
}
