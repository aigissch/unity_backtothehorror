using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartyActions : MonoBehaviour {

    float velocidadVuelo = 1.0f;
    bool tomate;


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tomate")
        {
            tomate = true;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKey("right"))
        {
            transform.position = new Vector3(
                transform.position.x + velocidadVuelo,
                transform.position.y,
                transform.position.z
            );

        }

        if (Input.GetKey("up"))
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y + velocidadVuelo,
                transform.position.z
            );


        }

        if(tomate){
            Debug.Log("Choque");
        }

    }
}
