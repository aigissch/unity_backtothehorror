using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TerminarJuego : MonoBehaviour
{

    public Rigidbody2D rb;
    int numeroPlutonios;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Marty" && Input.GetKey("f"))
        {
            numeroPlutonios = Plutonio.getPlutonio();
            if (numeroPlutonios == 4)
            {
                SceneManager.LoadScene("escenaFinal");
            }
            else
            {
                Debug.Log("¡Aún no tienes los 4 plutonios!");
            }
        }


    }
}
