using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    public int score;
    public TMPro.TMP_Text scoreDisplay;

    public void Start()
    {
        scoreDisplay.SetText("Score: 0");

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cloud")
        {
            updateScore(1);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("ThunderCloud"))
        {
            updateScore(-1);
            Destroy(collision.gameObject);
        }
    }

    public void updateScore(int value)
    {
        score = score + value;

        if (score <= 0)
        {
            score = 0;
        }

        scoreDisplay.SetText("Score: " + score);

    }

}
