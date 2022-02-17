using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuertePorMano : MonoBehaviour {

    public GameObject jugador;
    public Animator animation;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == jugador && animation.GetCurrentAnimatorStateInfo(0).IsName("Mano2"))
        {
            Debug.Log("Ay me ha tocado la mano");
            Vidas.DisminuirVida();
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
