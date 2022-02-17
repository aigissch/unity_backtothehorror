using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirCaja : MonoBehaviour {
    public Rigidbody2D rb;
    public GameObject plutonio;
    public GameObject caja;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    private void OnCollisionStay2D(Collision2D collision) // AL GOLPEAR A LA CAJA
    {
        if (collision.gameObject.tag == "Cofre")
        {
            // aparecer plutonio
            // destruir caja
            Destroy(caja);
            plutonio.GetComponent<Renderer>().enabled = true;
            //SpriteRenderer spriteRenderer = plutonio.GetComponent<Renderer>();
            // spriteRenderer.enabled = true;

        }

        if (collision.gameObject.tag == "Plutonio" == true && Input.GetKey("f") )
        {
            Plutonio.AñadirPlutonio();
            Destroy(plutonio);
        }
    }

}
