using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullet;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bullet, transform.position, transform.rotation); 
            //TODO: change transform position to front of object, instead of center, then enable friendly fire
        }
	}
}
