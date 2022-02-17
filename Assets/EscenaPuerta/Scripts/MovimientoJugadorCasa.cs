using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoJugadorCasa : MonoBehaviour
{

    public float velocidad = 0.1f;
    ///public float velocidadEscalera = 0.08f;
    float salto = 7.0f;
   
    bool derecha = true;
    bool suelo;
    bool escalera = false;
    bool ventana = false;
    bool puerta = false;

    public Rigidbody2D rb;
    public Animator animator;

    // Use this for initialization 
    void Start()
    {
        
    }

    // Controla cuando se producen colisiones identificando el objeto
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            suelo = true;
            animator.SetBool("Saltando", false);
            
        }
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("right"))
        {
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
        else
        {
            animator.SetBool("Caminando", false);
        }

        if (Input.GetKey("space") && suelo && !escalera && !puerta)
        {
            animator.SetBool("Saltando", true);
            animator.SetBool("Caminando", false);
            Saltar(salto);
            suelo = false;
        }

        
   
    }

    void Giro()
    {
        if (derecha)
        {
            derecha = false;
        }
        else
        {
            derecha = true;
        }
        transform.localScale = new Vector3(
            -transform.localScale.x,
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

  
}
