using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoviemientoCritterDerecha : MonoBehaviour {

    public GameObject critter;
    public float velocidad = 0.1f;
    public GameObject limitederecha;
    public GameObject jugador;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == limitederecha)
        {
            transform.position = new Vector3(
                -11, -2, 0);
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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3
        (
            transform.position.x + velocidad,
            transform.position.y,
            transform.position.z
        );
    }
}

