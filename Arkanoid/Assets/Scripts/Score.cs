using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

   public Text scoreText;
   public  int score;



    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text =score.ToString();
    }


}



 
