using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDrop : MonoBehaviour {

    public bool isHoldingSomething = false;
    public object heldObject;
    public float holdDistance;
    public float pickupDistance = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(!isHoldingSomething) {
            if (Physics.Raycast(transform.position, transform.down, out hitInfo, pickupDistance))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    hitInfo.collider.transform.parent = transform.parent;
                    hitInfo.collider.rigidbody.isKinematic = true;
                    Vector3 newPosition = hitInfo.collider.transform.position;
                    newPosition.x = transform.position.x;
                    newPosition.y = transform.position.y;
                    newPosition.z = transform.position.z + holdDistance;
                    hitInfo.collider.traansform.position = newPosition;
                    heldObject = hitInfo.collider.gameObject;
                    isHoldingSomething = true;
                }
            }
        } else
        {
            if (Input.GetMouseButtonDown(0))
            {
                heldObject.rigidbody.isKinematic = false;
                heldObject.GetComponent<transfrom>.parent = null;
                heldObject = null;
                isHoldingSomething = false;
            }
        }
	}
}
