using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manos : MonoBehaviour {

	public GameObject mano1;

	void Start () {
		CambioPosicion();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void CambioPosicion(){
 		float xPosition = Random.Range(-16,11);
		mano1.transform.position = new Vector3(
										xPosition,
										transform.position.y,
										transform.position.z
										); 
		Invoke("CambioPosicion", 1);
	}

}
