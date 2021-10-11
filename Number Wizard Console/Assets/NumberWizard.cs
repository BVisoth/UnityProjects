using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Wellcome to the funny Number Wizard!");
        Debug.Log("Pick a number");
        Debug.Log("The Highest you can go is: " + max);
        Debug.Log("The Lowest number you can go is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push up = Higher, Push down = Lower, Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Poggers");
            StartGame();
        }
        void NextGuess()
        {
            guess = (max + min) / 2;
            Debug.Log("Is your number: " + guess);
        }

    }
}
