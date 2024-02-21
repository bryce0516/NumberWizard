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



  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      Debug.Log("Up arrow key was pressed.");
      min = guess;
      NextGuess();
      Debug.Log("Guess min" + min);
    }
    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      Debug.Log("Down arrow key was pressed.");
      max = guess;
      NextGuess();
      Debug.Log("Guess max" + max);
    }
    if (Input.GetKeyDown(KeyCode.Return))
    {
      Debug.Log("Enter key was pressed.");
      StartGame();
    }
  }
  void StartGame()
  {
    max = 1000;
    min = 1;
    guess = 500;
    Debug.Log("Welcome to number wizard, yo");
    print("Welcome to number wizard ....");
    Debug.Log("Pick a number in your head, but don't tell me!");
    Debug.Log("The highest number you can pick is: >>> " + max);
    Debug.Log("The lowest number you can pick is: >>> " + min);
    Debug.Log("Is your number higher or lower than 500?");
    Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    max = max + 1;
  }

  void NextGuess()
  {
    guess = (max + min) / 2;
  }
}
