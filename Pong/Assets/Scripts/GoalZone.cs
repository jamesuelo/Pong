using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalZone : MonoBehaviour
{
    public Text scoreText;
    int score;

    void Awake()
    {
        score = 0;
        scoreText.text = "" + score.ToString();
    }

   private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.tag == "ball")
            {
                score++;
                scoreText.text = score.ToString();
            }
        }
}
