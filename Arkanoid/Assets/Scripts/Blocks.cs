using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{

    public int health;
    public int reward;

    void OnCollisionEnter2D(Collision2D other)
    {

        health--;
        if(health <= 0)
        {
            //destroy the whole block
            other.gameObject.GetComponent<Score>().IncreaseScore(reward);
            Destroy(gameObject);
        }
    }

}
