using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI orangeRoundScoreText;
    public TextMeshProUGUI blueRoundScoreText;
    public TextMeshProUGUI orangeTotalScoreText;
    public TextMeshProUGUI blueTotalScoreText;
    public int orangeRoundScoreValue = 0;
    public int blueRoundScoreValue = 0;
    public int orangeTotalScoreValue = 0;
    public int blueTotalScoreValue = 0;

    public void CalcRoundScore()
    {
        //if orange round score > blue round score, total score += orange-blue
        if(orangeRoundScoreValue > blueRoundScoreValue)
        {
            orangeTotalScoreValue += orangeRoundScoreValue - blueRoundScoreValue;
        }

        else if(blueRoundScoreValue > orangeRoundScoreValue)
        {
            blueTotalScoreValue += blueRoundScoreValue - orangeRoundScoreValue;
        }

        orangeTotalScoreText.text = orangeTotalScoreValue.ToString();
        blueTotalScoreText.text = blueTotalScoreValue.ToString();
        orangeRoundScoreValue = 0;
        blueRoundScoreValue = 0;

        orangeRoundScoreText.text = orangeRoundScoreValue.ToString();
        blueRoundScoreText.text = blueRoundScoreValue.ToString();
    }
}
