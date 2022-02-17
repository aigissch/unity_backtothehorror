using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarPlutonio : MonoBehaviour {

    private int numeroPlutonio;

    public Sprite plutonio0;
    public Sprite plutonio1;
    public Sprite plutonio2;
    public Sprite plutonio3;
    public Sprite plutonio4;

    public Canvas canvas;

    // Use this for initialization
        void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        numeroPlutonio = Plutonio.getPlutonio();

        switch (numeroPlutonio)
        {
            case 1:
                GetComponent<Image>().sprite = plutonio1;
                break;

            case 2:
                GetComponent<Image>().sprite = plutonio2;
                break;

            case 3:
                GetComponent<Image>().sprite = plutonio3;
                break;

            case 4:
                GetComponent<Image>().sprite = plutonio4;
                break;

        }
    }
}
