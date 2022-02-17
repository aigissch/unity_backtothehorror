using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerPepsi : MonoBehaviour {

    public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision) // Curar al coger coca cola
    {

        if (collision.gameObject.tag == "Marty")
        {
            Vidas.AumentarVida();
            Destroy(gameObject);
        }
    }


}
