using UnityEngine;
using System.Collections;

public class GoHomeGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Welcome to Go Home!");
        print("A game where you need to find you way home.");
    }

    // Update is called once per frame
    void Update () {
        int numberOfSteps = 10;
        float distance = 0.0f;

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("After " + numberOfSteps + " steps, you are " + distance + " meters away from home.");
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("After " + numberOfSteps + " steps, you are " + distance + " meters away from home.");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("After " + numberOfSteps + " steps, you are " + distance + " meters away from home.");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("After " + numberOfSteps + " steps, you are " + distance + " meters away from home.");
        }

    }
}
