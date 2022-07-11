using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeperCans : MonoBehaviour
{
    //public int favNumber = 25;
    //public string myText = "Hello, World!";
    //public bool mySwitch = true;
    public TextMeshProUGUI scoreText;
    public int scoreValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("My favorite number is " + favNumber);
        //Debug.Log("I like to say " + myText);
        //Debug.Log("the switch is: " + mySwitch);
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + scoreValue.ToString();

    }
}
