using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesaparicionJugador : MonoBehaviour {

    public string nombreEscena;

    // Use this for initialization

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jason")
        {
            Vidas.Morir();
        }

    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {		
	}
}
