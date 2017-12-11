using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScoreOnCollide : MonoBehaviour {

    public int pointValue;
    //TODO: Make score depend on difficulty
    //TODO: make rewards for getting scores

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter()
    {

        GameManager.score += pointValue;
    }
}
