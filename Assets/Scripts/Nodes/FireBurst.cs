using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBurst : MonoBehaviour
{
    public float speed = 1;
    public float addition = 30;
    
    void Start()
    {
        //GameObject Burst = new GameObject("Burst", typeof(Rigidbody2D), typeof(CircleCollider2D));
    }

    
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 1f) * Time.deltaTime * speed);

    }

    /*void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            speed += addition;
            GameManager.fire+=5;
            GameManager.frost -= 5;

        }

    }*/
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ball")
        {
            speed += addition;
            GameManager.fire += 5;
            GameManager.frost -= 5;

        }

    }


}
