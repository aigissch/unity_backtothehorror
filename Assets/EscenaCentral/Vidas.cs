using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class Vidas {
    private static int contadorVidas = 6;
 

    public static void AumentarVida()
    {
        if (contadorVidas == 6){
            Debug.Log("¡¡¡VIDA AL MÁXIMO!!!");
        } else  {
            contadorVidas++;
            
        }
        
    }

    public static void DisminuirVida()
    {
         
        contadorVidas--;
        if (contadorVidas == 0){
            Morir();
        } 
    }

    public static void Morir(){
        contadorVidas = 6;
       
        SceneManager.LoadScene("escenaMuerte");
    }

    public static int getVidas()
    {
        return contadorVidas;
    }
}
