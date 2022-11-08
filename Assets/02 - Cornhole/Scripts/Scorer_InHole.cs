using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer_InHole : MonoBehaviour
{
    public GameManager gameManager;
    private bool isTriggeringBlueHole = false;
    private bool isTriggeringOrangeHole = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blue"))
        {
            isTriggeringBlueHole = true;
            StartCoroutine(UpdateScore());
        }

        else if (other.gameObject.CompareTag("Orange"))
        {
            isTriggeringOrangeHole = true;
            StartCoroutine(UpdateScore());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Blue"))
        {
            isTriggeringBlueHole = false;
            StartCoroutine(UpdateScore());
        }

        else if (other.gameObject.CompareTag("Orange"))
        {
            isTriggeringOrangeHole = false;
            StartCoroutine(UpdateScore());
        }
    }

    IEnumerator UpdateScore()
    {
        //wait 1 second
        yield return new WaitForSeconds(1);

        //if it's STILL triggering...
        if (isTriggeringBlueHole == true)
        {
            gameManager.blueRoundScoreValue += 3;
        }

        else if (isTriggeringOrangeHole == true)
        {
            gameManager.orangeRoundScoreValue += 3;
        }

        //update score
        gameManager.orangeRoundScoreText.text = gameManager.orangeRoundScoreValue.ToString();
        gameManager.blueRoundScoreText.text = gameManager.blueRoundScoreValue.ToString();
    }
}
