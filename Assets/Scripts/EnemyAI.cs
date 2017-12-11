using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    Rigidbody ourRigidBody;
    public float speed;

    // Use this for initialization
    void Start () {
        ourRigidBody = GetComponent<Rigidbody>();
        Vector3 newVelocity = Vector3.zero;
        newVelocity.x = -speed; 
        ourRigidBody.velocity = newVelocity;
    }
	
	// Update is called once per frame
	void Update () {
            if (Camera.main.WorldToScreenPoint(transform.position).x > Screen.width)
            {
                Vector3 newVelocity = Vector3.zero;
                newVelocity.x = -speed;
                ourRigidBody.velocity = newVelocity;
            }
            else if (Camera.main.WorldToScreenPoint(transform.position).x < 0)
            {
                Vector3 newVelocity = Vector3.zero;
                newVelocity.x = speed;
                ourRigidBody.velocity = newVelocity;
            }
        }
	//TODO: abstract out movement pattern
    //TODO: make movment pattern relate to player location
    //TODO: make movement pattern depend on enemy type
	
}
