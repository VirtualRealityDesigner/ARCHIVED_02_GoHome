using UnityEngine;
using System.Collections;

public class GoHomeGame : MonoBehaviour {

    int numberOfSteps = 1;
    Vector2 homeLocation = new Vector2(2.0f, 3.0f);
    Vector2 playerLocation = new Vector2(5.0f, 1.0f);

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
            playerLocation = playerLocation + Vector2.down;
            PrintUpdateAndContinue();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerLocation = playerLocation + Vector2.up;
            PrintUpdateAndContinue();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerLocation = playerLocation + Vector2.left;
            PrintUpdateAndContinue();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerLocation = playerLocation + Vector2.right;
            PrintUpdateAndContinue();
        }

    }

    void PrintUpdateAndContinue()
    {
        Vector2 distance = homeLocation - playerLocation;
        print("After " + numberOfSteps + " steps, you are " + distance + " meters away from home.");
        numberOfSteps++;
    }
}
