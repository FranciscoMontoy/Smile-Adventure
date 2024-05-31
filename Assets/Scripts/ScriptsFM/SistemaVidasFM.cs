using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SistemaVidasFM : MonoBehaviour
{
    public int vidas = 3; // N�mero inicial de vidas 
    public TMP_Text textoVidas; // Asigna el TMP_Text de la UI en el inspector 
    public string nombreEscenaGameOver = "GameOver"; // Nombre de la escena de Game Over 

    void Start()
    {
        // Actualizar el texto de la UI al iniciar el juego
        ActualizarTextoVidas();
    }

    // M�todo para reducir las vidas
    public void ReducirVidas()
    {
        if (vidas > 0)
        {
            vidas--;
            ActualizarTextoVidas();

            if (vidas == 0)
            {
                // L�gica cuando se acaban las vidas
                Debug.Log("Game Over");
                // Cargar la escena de Game Over
                SceneManager.LoadScene(nombreEscenaGameOver);
            }
        }
    }

    // M�todo para actualizar el texto de las vidas en la UI
    void ActualizarTextoVidas()
    {
        if (textoVidas != null)
        {
            textoVidas.text = "Vidas: " + vidas;
        }
    }

    // M�todo para simular recibir da�o (puedes llamarlo desde otros scripts cuando el personaje reciba da�o)
    public void RecibirDanio()
    {
        ReducirVidas();
    }
}

