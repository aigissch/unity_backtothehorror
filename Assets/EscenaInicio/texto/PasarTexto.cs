using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarTexto : MonoBehaviour {

    private int contador = 0;
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;
    public GameObject texto4;
    public GameObject texto5;
    public GameObject intro;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            contador++;
            switch (contador)
            {
                case 1: Destroy(texto1);
                    break;

                case 2: Destroy(texto2);
                    break;

                case 3: Destroy(texto3);
                    break;

                case 4: Destroy(texto4);
                    break;

                case 5: Destroy(texto5); Destroy(intro);
                    SceneManager.LoadScene("escenaInicio3");
                    break;
            }
        }

    }
}
