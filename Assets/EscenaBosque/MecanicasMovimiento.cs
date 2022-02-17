using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MecanicasMovimiento : MonoBehaviour {

    public MovimientosJugador jugador;
    public float velocidadRelentizada;
    public GameObject enemy;
    public GameObject cofre;


    // Use this for initialization

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == cofre)
        {
            Debug.Log("Has Ganado");
            Destroy(enemy);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Arbusto")
        {
            jugador.velocidad = velocidadRelentizada;

        }

        if (collision.gameObject.tag == "Arbusto" && Input.GetKey(KeyCode.F))
        {
            Destroy(collision.gameObject);
            jugador.velocidad = 0.1f;
        }

        if (collision.gameObject.tag == "conosBosque")
        {
            SceneManager.LoadScene("escenaCentral");
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Arbusto")
        {
            jugador.velocidad = 0.1f;

        }

    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
