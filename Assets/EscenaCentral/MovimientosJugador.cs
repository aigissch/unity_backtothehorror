using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientosJugador : MonoBehaviour {

    public float velocidad =0.1f;
    public float velocidadEscalera = 0.08f;
    float salto = 5.0f;
    int sinGravedad = 0;
    int conGravedad = 1;
    bool derecha = true;
    bool suelo;
    bool escalera = false;
    bool ventana = false;
    bool puerta = false;

    public Rigidbody2D rb;
    public Animator animator;

	// Use this for initialization 
	void Start () {
        
	}

    // Controla cuando se producen colisiones identificando el objeto
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Suelo"){
            suelo = true;
            animator.SetBool("Saltando", false);
            animator.SetBool("Subiendo", false);            
        }
        
        if (collision.gameObject.tag == "Escalera"){
            escalera = true;
        }
        
        if (collision.gameObject.tag == "Ventana"){
            ventana = true;
        }

        if (collision.gameObject.tag == "Puerta"){
            puerta = true;
        }
        
        if (collision.gameObject.tag == "AlBosque"){
            SceneManager.LoadScene("escenaBosque");
        }

        if (collision.gameObject.tag == "Alcantarilla")
        {
            SceneManager.LoadScene("escenaAlcantarilla");
        }
    }

    // Controla cuando deja de producirse una colisión
    private void OnCollisionExit2D(Collision2D outCollision)
    {
        if (outCollision.gameObject.tag == "Escalera"){
            escalera = false;
            rb.gravityScale = conGravedad;
        }

        if (outCollision.gameObject.tag == "Puerta"){
            puerta = false;
        }
    }

    // Update is called once per frame
    void Update () {
       

        if (Input.GetKey("right")){
            transform.position = new Vector3(
                transform.position.x + velocidad,
                transform.position.y,
                transform.position.z
            );

            animator.SetBool("Caminando", true);

            if (!derecha)
            {
                Giro();
            }
        }

        else if (Input.GetKey("left"))
        {
            transform.position = new Vector3(
                transform.position.x - velocidad,
                transform.position.y,
                transform.position.z
            );

            animator.SetBool("Caminando", true);

            if (derecha)
            {
                Giro();
            }
        }
        else {
            animator.SetBool("Caminando", false);
        }

        if (Input.GetKey("space") && suelo && !escalera && !puerta)
        {
            animator.SetBool("Saltando", true);
            animator.SetBool("Caminando", false);
            Saltar(salto);
            suelo = false;
        }

        if (Input.GetKey("up") && escalera)
        {
            rb.gravityScale = sinGravedad;
            animator.SetBool("Subiendo", true);            
            Subir();
        }

        else if (Input.GetKey("down") && escalera)
        {
            animator.SetBool("Subiendo", true);            
            Bajar();
        }
        else
        {
            animator.SetBool("Subiendo", false);            
        }
 
        if (Input.GetKey("f") && ventana) // CAMBIO DE ESCENA VENTANA
        {
            SceneManager.LoadScene("escenaCielo");
        }
        else if (Input.GetKey("f") && puerta) { // CAMBIO DE ESCENA PUERTA
            SceneManager.LoadScene("escenaPuerta");
             
        }
    }

    void Giro(){
        if (derecha){
            derecha = false;
        }else{
            derecha = true;
        }
        transform.localScale = new Vector3(
            - transform.localScale.x, 
            transform.localScale.y,
            transform.localScale.z
        );

    }

    void Volar(float impulso)
    {
        rb.velocity = new Vector3(0, impulso, 0);

    }

    void Saltar(float impulso)
    {
        rb.velocity = new Vector3(0, impulso, 0);
    }

    void Subir()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y + velocidadEscalera,
            transform.position.z
        );
    }
    
    void Bajar()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y - velocidadEscalera,
            transform.position.z
        );
    }
}
