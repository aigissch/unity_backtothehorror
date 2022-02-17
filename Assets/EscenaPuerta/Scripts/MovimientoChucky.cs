using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoChucky : MonoBehaviour
{

    private int decidirDireccion;
    bool derecha;

    public float velocidad = 0.2f;

    public Rigidbody2D rb;
  

    // Use this for initialization
    void Start()
    {
        decidirDireccion = Random.Range(0, 2); // 0 derecha, 1 izquierda
        

        if(decidirDireccion == 0)
        {
            derecha = true;
             

        }else
        {
            derecha = false;
            transform.localScale = new Vector3(
             -transform.localScale.x,
            transform.localScale.y,
            transform.localScale.z
);
        }
    }
 
    // Update is called once per frame
    void Update()
        {
        if (derecha)
        {
            transform.position = new Vector3(
                transform.position.x + velocidad,
                transform.position.y,
                transform.position.z
            );

            if (!derecha)
            {
                Giro();
            }
        }

        if (!derecha)
        { //hacia la izquierda
            transform.position = new Vector3(
             transform.position.x - velocidad,
                transform.position.y,
                transform.position.z
            );

            if (derecha)
            {
                Giro();
            }
        }
    }



    private void OnCollisionStay2D(Collision2D collision) // SER GOLPEADO POR EL CHUCKY
    {

        if (collision.gameObject.tag == "Pared")
        {
            Giro();
        }

        if (collision.gameObject.tag == "Marty")
        {
            Giro();
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


}
