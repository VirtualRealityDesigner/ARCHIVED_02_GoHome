using UnityEngine;
using System.Collections;

public class GoHomeGame : MonoBehaviour {

    int numberOfSteps = 1;
    float distance = 5.0f;

    // Use this for initialization
    void Start() {
        PrintWelcomeMessage();
    }

    void PrintWelcomeMessage()
    {
        print("Welcome to Go Home!");
        print("A game where you need to find you way home.");
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PrintUpdateAndContinue();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PrintUpdateAndContinue();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            distance--;
            PrintUpdateAndContinue();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            distance++;
            PrintUpdateAndContinue();
        }

    }

    void PrintUpdateAndContinue()
    {
        print("After " + numberOfSteps + " steps, you are " + distance + " meters away from home.");
        numberOfSteps++;
    }
}
