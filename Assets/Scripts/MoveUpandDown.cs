using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpandDown : MonoBehaviour {

    public float playerSpeed = 1.0f; //? what is the f

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //TODO: Add in rotational movement
        //TODO: Add in directional 
        Vector3 newPosition = transform.position;
        newPosition.y += Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        transform.position = newPosition;
	}
}
