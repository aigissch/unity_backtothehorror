using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AbrirPuerta : MonoBehaviour {

    public Rigidbody2D rb;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnCollisionStay2D(Collision2D collision) //  
    {
        if (collision.gameObject.tag == "Puerta" ) { if (Input.GetKey("f")) 
            SceneManager.LoadScene("escenaCentral");
        }
    }
}
