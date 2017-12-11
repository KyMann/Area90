using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent( typeof(Rigidbody))]

public class BulletAI : MonoBehaviour {

    Rigidbody ourRigidBody;
    public float speed;
    //TODO: change bullet size depending on player perks
    //TODO: change bullet damage depending on player perks

	// Use this for initialization
	void Start () {
        ourRigidBody = GetComponent<Rigidbody>();
        Vector3 newVelocity = Vector3.zero;
        newVelocity.x = speed; //don't need time.deltatime since we're doing velocity not position
        ourRigidBody.velocity = newVelocity;
        //TODO: make bullet layer depend on creator, or make inheriting objects
    }

    // Update is called once per frame
	void Update () {
        //Vector3 newPosition = transform.position;
        //newPosition.x += speed * Time.deltaTime;
        //transform.position = newPosition;
	}
}
