using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PararTomates : MonoBehaviour {

    public GameObject jugador;
    List <GameObject> tomates;

    // Use this for initialization

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == jugador)
        {
            Destroy(GameObject.FindWithTag("Tomate"));
        }    
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
