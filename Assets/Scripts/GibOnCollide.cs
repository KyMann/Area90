using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollide : MonoBehaviour {

    public GameObject[] physicsGibs;
    public GameObject[] staticGibs;
    public float explosionForce;
    public float spawnRadius = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter()
    {
        //TODO: Add health management
        foreach(GameObject gib in physicsGibs)
        {
            GameObject gibInstance =Instantiate(gib, transform.position+ Random.insideUnitSphere*spawnRadius, transform.rotation) as GameObject;
            gibInstance.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, transform.position, spawnRadius);
        }
        foreach(GameObject gib in staticGibs)
        {
            GameObject gibInstance = Instantiate(gib, transform.position, transform.rotation) as GameObject;
        }
        Destroy(gameObject);
    }
}
