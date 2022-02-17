using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarVidas : MonoBehaviour
{
    private int numeroVidas;

    public Sprite vida0;
    public Sprite vida1;
    public Sprite vida2;
    public Sprite vida3;
    public Sprite vida4;
    public Sprite vida5;
    public Sprite vida6;

    public Canvas canvas;
     
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        numeroVidas = Vidas.getVidas();

        switch (numeroVidas)
        {
            case 1:
                GetComponent<Image>().sprite = vida1;
                break;

            case 2:
                GetComponent<Image>().sprite = vida2;
                break;

            case 3:
                GetComponent<Image>().sprite = vida3;
                break;

            case 4:
                GetComponent<Image>().sprite = vida4;
                break;

            case 5:
                GetComponent<Image>().sprite = vida5;
                break;

             case 6:
                GetComponent<Image>().sprite = vida6;
                break;
        }
    }
}