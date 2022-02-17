using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class InstantiateTomate : MonoBehaviour {

    public GameObject tomampiro;
    public GameObject azotea;
    public Rigidbody2D rb;
    public float velocidadTomate;
    bool plutonioEncontrado = false;
    bool lanzarSeta = true;

    //float width;
    //float height;
    //RectTransform rt;
    public float vida = 2;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tomate"){

        }        
    }

    void Start()
    {


        //Debug.Log("POSX: "+ posX  + "POSY: " + posY);

        //tomampiro = (GameObject)Instantiate(tomampiro);
        //rt = (RectTransform)tomampiro.transform;

        //width = rt.rect.width;
        //height = rt.rect.height;


        Debug.Log(tomampiro.transform.position);
        Debug.Log("Screen Width: " + Screen.width);
    }

    // Update is called once per frame
    void Update () {
        if(!plutonioEncontrado){
            if (lanzarSeta)
            {
                LanzaSetas();
                lanzarSeta = false;
        }
        }

        //if(tomampiro.transform.position.y > azotea.transform.position.y){
        //    Destroy(tomampiro);
        //}
    
       
    }


    void LanzaSetas(){

        float posX = tomampiro.transform.position.x;
        float posY = tomampiro.transform.position.y;

        for (int i = 0; i < 3; i++)
        {
            //Instantiate(tomampiro, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
            Instantiate(tomampiro, new Vector3(Random.Range(-6, 6), Random.Range(32, 40), 0), Quaternion.identity);

            Debug.Log("AHORA-POSX: " + posX + "POSY: " + posY);
        }
    }
}
