using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatarChucky : MonoBehaviour {
    public Rigidbody2D rb;

    void Start () {

    }

    private void OnCollisionStay2D(Collision2D collision) // SER GOLPEADO POR EL CHUCKY
    {

        if (collision.gameObject.tag == "Marty"){
            Vidas.DisminuirVida();
        }
    }

    void OnTriggerEnter2D(Collider2D other) // SALTAR ENCIMA DEL CHUCKY
    {
        if (other.gameObject.tag == "Marty") {

             
           // string path = "chucky";
            //Sprite chuckyMuerto = Resources.Load<Sprite>(path);
            //gameObject.sprite = chuckyMuerto;
            //gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load(path) as Sprite;

            Destroy(gameObject);
            Contador.Aumentar();

        }
    }

    // Update is called once per frame
    void Update () {
		
	}

   
}
