using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reiniciaTomates : MonoBehaviour {

    public GameObject tomate;
    public Rigidbody2D rb;
    public GameObject jugador;
    float velocidadTomate = 0.08f;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Azotea")
        {
            Debug.Log("Llega");

            SubirTomate();
        }

        if (collision.gameObject == jugador)
        {
            Vidas.DisminuirVida();
            Debug.Log("aaaay");
        }
    }



    // Use this for initialization
    void Start () {
        rb.gravityScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
        tomate.transform.position = new Vector3(
          transform.position.x,
          transform.position.y - velocidadTomate,
          transform.position.z
      );
    }


    public void PararTomates()
    {
        //Destroy(GameObject.FindGameObjectWithTag("Tomate"));
        Debug.Log("Dentro de la clase de riniciar");
    }

    void SubirTomate(){
        tomate.transform.position = new Vector3(
          transform.position.x,
          32,
          transform.position.z
      );
    }
}
