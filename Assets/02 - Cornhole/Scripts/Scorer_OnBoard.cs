using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer_OnBoard : MonoBehaviour
{
    public GameManager gameManager;
    private bool isTriggeringBlueBoard = false;
    private bool isTriggeringOrangeBoard = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blue"))
        {
            isTriggeringBlueBoard = true;
            //gameManager.blueRoundScoreValue += 1;
            StartCoroutine(UpdateScore());
        }

        else if (other.gameObject.CompareTag("Orange"))
        {
            isTriggeringOrangeBoard = true;
            //gameManager.orangeRoundScoreValue += 1;
            StartCoroutine(UpdateScore());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Blue"))
        {
            isTriggeringBlueBoard = false;
            StartCoroutine(UpdateScore());
        }

        else if (other.gameObject.CompareTag("Orange"))
        {
            isTriggeringOrangeBoard = false;
            StartCoroutine(UpdateScore());
        }
    }

    IEnumerator UpdateScore()
    {
        //wait 1 second
        yield return new WaitForSeconds(1);

        //if it's STILL triggering...
        if(isTriggeringBlueBoard == true)
        {
            gameManager.blueRoundScoreValue += 1;
        }

        else if(isTriggeringOrangeBoard == true)
        {
            gameManager.orangeRoundScoreValue += 1;
        }

        //update score
        gameManager.orangeRoundScoreText.text = gameManager.orangeRoundScoreValue.ToString();
        gameManager.blueRoundScoreText.text = gameManager.blueRoundScoreValue.ToString();
    }
}
