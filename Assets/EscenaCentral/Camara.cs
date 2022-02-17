using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

    public Transform jugador;
    public Transform suelo;

	// Use this for initialization 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = jugador.position + new Vector3(0,2,-10);
		
	}
}
