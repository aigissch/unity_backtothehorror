using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirCofre : MonoBehaviour {

    public GameObject jugador;
    bool cofreRecogido = false;
    public GameObject cofre;
    public GameObject plutonio;
    bool cogerPlutonio = true;

    // Use this for initialization

    void Start () {

        plutonio.SetActive(false);
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == jugador)
        {
            Destroy(cofre);
            plutonio.SetActive(true);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (cogerPlutonio && Input.GetKey("f"))
        {
            cogerPlutonio = false;
            Plutonio.AñadirPlutonio();
            Destroy(plutonio);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
