using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviemientoCritter : MonoBehaviour {

    public GameObject critter;
    public float velocidad = 0.1f;
    public GameObject limiteizquierda;
    public GameObject jugador;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == limiteizquierda)
        {
            transform.position = new Vector3(
                9, 1, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == jugador)
        {
            Vidas.Morir();
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3
        (
            transform.position.x - velocidad,
            transform.position.y,
            transform.position.z
        );
	}
}
