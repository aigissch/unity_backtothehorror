using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CambioDeEscenaEscalera : MonoBehaviour {

    public GameObject salidaEscena;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == salidaEscena)
        {
            SceneManager.LoadScene("escenaCentral");
        }    
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
