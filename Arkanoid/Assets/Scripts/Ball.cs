using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
      
    }

    private float hitFactor(Vector2 ballPos,Vector2 racketPos,float racketWidth) 
    {
        //ascii art:
        //
        // 1  -0.5    0    0.5   1  X VALUE
        // ========================= RACKET
        //
        return (ballPos.x - racketPos.x) / racketWidth;
    }

    private void OnCollisionEnter2D(Collision2D col) {
        // Hit the racket?
        if (col.gameObject.name == "Player")
        {
            // calculate hit Factor
            float x = hitFactor(transform.position,
                col.transform.position, col.collider.bounds.size.x);
            
            //Calculate direction, set lengh to 1
            Vector2 dir = new Vector2(x, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;

            Debug.Log(dir);


        }
    }


}