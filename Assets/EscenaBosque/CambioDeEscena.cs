using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour {

    public GameObject jugador;

    // Use this for initialization

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == jugador)
        {
            SceneManager.LoadScene("escenaCentral");
        }   
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
