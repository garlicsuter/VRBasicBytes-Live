using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeperCans : MonoBehaviour
{
    public int favNumber = 25;
    public string myText = "Hello, World!";
    public bool mySwitch = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("my favorite number is: " + favNumber);
        Debug.Log("I like to say: " + myText);
        Debug.Log("The switch is: " + mySwitch);
    }
}
