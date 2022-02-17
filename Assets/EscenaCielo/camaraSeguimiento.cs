using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraSeguimiento : MonoBehaviour {

    public Transform jugador;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = jugador.position + new Vector3(0, 0, -10);

    }
}
