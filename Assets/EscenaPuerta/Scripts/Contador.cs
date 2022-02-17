using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Contador
{

    private static int contador = 0;
    private static int contadorFalta = 6;

    static float t = 1.0F;

    public static GameObject sujetar;
    public static int contadorNum = 0;

    static GameObject seis = new GameObject("6");
    static GameObject cinco = new GameObject("5");
    static GameObject cuatro = new GameObject("4");
    static GameObject tres = new GameObject("3");
    static GameObject dos = new GameObject("2");
    static GameObject uno = new GameObject("1");


    public static void Aumentar()
    {
        contador++;
        contadorFalta--;

        contadorNum++;
        Numeros(contadorNum);
    }

    public static void InicioNumeros()
    {
        
        
        SpriteRenderer renderer = seis.AddComponent<SpriteRenderer>();
        string path = "Numeros/seis";
        Sprite seisPng = Resources.Load<Sprite>(path);
        renderer.sprite = seisPng;
        
    }

    public static void Numeros(int contadorNum)
    {

        switch (contadorNum)
        {
            case 1: //sale 5
                GameObject.Destroy(seis);

                SpriteRenderer renderer5 = cinco.AddComponent<SpriteRenderer>();
                string path5 = "Numeros/cinco";
                Sprite cincoPng = Resources.Load<Sprite>(path5);
                renderer5.sprite = cincoPng;

                Debug.Log("Has matado 1");
                break;

            case 2: //sale 4
                GameObject.Destroy(cinco);

                SpriteRenderer renderer4 = cuatro.AddComponent<SpriteRenderer>();
                string path4 = "Numeros/cuatro";
                Sprite cuatroPng = Resources.Load<Sprite>(path4);
                renderer4.sprite = cuatroPng;

                Debug.Log("Has matado 2");
                break;

            case 3: //sale 3
                GameObject.Destroy(cuatro);

                SpriteRenderer renderer3 = tres.AddComponent<SpriteRenderer>();
                string path3 = "Numeros/tres";
                Sprite tresPng = Resources.Load<Sprite>(path3);
                renderer3.sprite = tresPng;

                Debug.Log("Has matado 3");
                break;

            case 4: //sale 2
                GameObject.Destroy(tres);

                SpriteRenderer renderer2 = dos.AddComponent<SpriteRenderer>();
                string path2 = "Numeros/dos";
                Sprite dosPng = Resources.Load<Sprite>(path2);
                renderer2.sprite = dosPng;

                Debug.Log("Has matado 4");
                break;

            case 5: //sale 1
                GameObject.Destroy(dos);

                SpriteRenderer renderer1 = uno.AddComponent<SpriteRenderer>();
                string path1 = "Numeros/uno";
                Sprite unoPng = Resources.Load<Sprite>(path1);
                renderer1.sprite = unoPng;

                Debug.Log("Has matado 5");
                break;

            default:
                GameObject.Destroy(uno);
                ConseguirPremio();

                Debug.Log("Has matado a todos");
                break;
        }
    }

    public static void ConseguirPremio()
    {
        sujetar = GameObject.FindWithTag("SujetarMoneda");
        // Dejamos caer el cofre con el premio
        GameObject.Destroy(sujetar);

    }
}