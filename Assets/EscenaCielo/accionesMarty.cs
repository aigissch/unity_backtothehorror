using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class accionesMarty : MonoBehaviour {

    float velocidadVuelo = 5.0f;
    public Rigidbody2D rbd;
    MovimientosJugador jugador;
    InstantiateTomate tomateInst;
    reiniciaTomates restart;
    bool tomate;

    public Transform tomateTrf;

    bool pasarpantalla = false;

     private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tomate")
        {
            tomate = true;
        }
        if (collision.gameObject.tag == "Plataforma")
        {
            //restart.PararTomates();
            Destroy(GameObject.FindWithTag("Tomate"));
            Debug.Log("Contacto con PLATAFORMA");
            pasarpantalla = true;
        }

        if (collision.gameObject.tag == "Reinicio")
        {
            //TODO Go to escenario
        }

        if (collision.gameObject.tag == "Azotea" && pasarpantalla )
        {
            SceneManager.LoadScene("escenaCentral");
        }

    }

    // Use this for initialization
    void Start () {



    }
	
	// Update is called once per frame
	void Update () {

        //Debug.Log(tomateTrf.position);

        if (Input.GetKey("right"))
        {
            rbd.velocity = new Vector3(Random.Range(velocidadVuelo, velocidadVuelo/2), velocidadVuelo/2, 0);

        }

        if (Input.GetKey("up"))
        {
            rbd.velocity = new Vector3(0, Random.Range(velocidadVuelo, velocidadVuelo / 2), 0);
            //jugador.Volar(velocidadVuelo);


        }

        if (Input.GetKey("left"))
        {
            rbd.velocity = new Vector3(Random.Range(-velocidadVuelo, -velocidadVuelo / 2), velocidadVuelo/2, 0);
            //jugador.Volar(velocidadVuelo);


        }

        if (Input.GetKey("down"))
        {
            rbd.velocity = new Vector3(0, Random.Range(-velocidadVuelo, -velocidadVuelo / 2), 0);
            //jugador.Volar(velocidadVuelo);


        }

        if (tomate){
            tomate = false;

            //tomateInst.vida--;
        }



    }
}
