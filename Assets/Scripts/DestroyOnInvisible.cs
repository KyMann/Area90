using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnInvisible : MonoBehaviour {

    private void OnBecameInvisible() //function called when object goes offscreen
    {
        Destroy(gameObject);
    }
}
