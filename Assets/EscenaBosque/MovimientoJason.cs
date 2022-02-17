using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJason : MonoBehaviour {
    public float velocidadjason = 0.05f;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(
            transform.position.x - velocidadjason,
            transform.position.y,
            transform.position.z);
	}
}
