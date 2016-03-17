using UnityEngine;
using System.Collections;

public class GoHomeGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int numberOfSteps = 10;
        float distance = 0.0f;
        print("Welcome to Go Home!");
        print("A game where you need to find you way home.");
        print("After " + numberOfSteps + " steps, you are " + distance + " meters away from home.");
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("down arrow was pressed");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("up arrow was pressed");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("left arrow was pressed");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("right arrow was pressed");
        }

    }
}
