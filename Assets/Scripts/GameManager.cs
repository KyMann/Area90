using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    //TODO: multiple player scores
    //TODO: instantiate player objects??
    public static int score;
    public static bool gameOver = false;
    public static int highscore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (score > highscore)
                {
                    highscore = score;
                }
                GameManager.score = 0;
                GameManager.gameOver = false;
                //Application.LoadLevel("TestLevel");\
                SceneManager.LoadScene("TestLevel");
            }
            
        }
	}

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 60, 40), "SCORE: " + score.ToString());
        GUI.Label(new Rect(0, 40, 80, 60), "HIGH SCORE: " + highscore.ToString());
        if (gameOver) {
            GUI.Label(new Rect(Screen.width / 2.0f - 30, Screen.height / 2.0f, 120, 20), "Game Over");
        }
    }
}
