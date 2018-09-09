using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int max = 99999;
        int min = 1;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a Number:");
        Debug.Log("Highest number you can pick is "+max+" :");
        Debug.Log("Lowest number you can pick is "+min+" :");
        Debug.Log("tell me if your number is higher or lower than 500");
        Debug.Log("Push up = higher, Push down = lower, Push Enter = correct");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow is pressed");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow is pressed");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter arrow is pressed");
        }
    }
}
