using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max = 1000;
    [SerializeField] int min = 1;
    [SerializeField] TextMeshProUGUI guessText;
    guessText.text = 'g';
    int guess;
    
    public void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        guessToString();
        max = max + 1 ;

    }
    public void Higher() {
        min = guess;
        NextGuess();
    }

    public void Lower()
    {
        max = guess;
        NextGuess();
    }

    

    public void NextGuess()
    {
        guessToString();

    }

    public void guessToString() {
        guess = Random.Range(min,max + 1);
        guessText.text = guess.ToString();
    }

}


































/*
public class NumberWizard: MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;
    public void Start() {
        StartGame();
    }

    public void StartGame() {


        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number");
        Debug.Log("The highest number is " + max);
        Debug.Log("The lowest number is " + min);
        Debug.Log("Tell me if your number is higher / lower then 500");
        Debug.Log("Push up ,down or enter");

    }

    public void Update() {

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();

        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();

        } else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("numbertrue");
            StartGame();
        }
    }

    public void NextGuess() {
        guess = (max + min) / 2;
        Debug.Log(guess);
    }
}

*/