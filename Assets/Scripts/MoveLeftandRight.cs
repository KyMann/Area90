using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftandRight : MonoBehaviour {

    public float playerSpeed = 1.0f; //? what is the f

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //TODO: Add in z turning
        //TODO: Add in directional speeds
        Vector3 newPosition = transform.position;
        newPosition.x += Input.GetAxis("Horizontal") * playerSpeed *Time.deltaTime; //delta time - amount of time since last update, smooths motion for high requirement renders
        transform.position = newPosition;
	}
}
