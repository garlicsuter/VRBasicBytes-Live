using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer_InHole : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blue"))
        {
            gameManager.blueRoundScoreValue += 3;
            UpdateScore();
        }

        else if (other.gameObject.CompareTag("Orange"))
        {
            gameManager.orangeRoundScoreValue += 3;
            UpdateScore();
        }
    }

    public void UpdateScore()
    {
        //update score
        gameManager.orangeRoundScoreText.text = gameManager.orangeRoundScoreValue.ToString();
        gameManager.blueRoundScoreText.text = gameManager.blueRoundScoreValue.ToString();
    }
}
