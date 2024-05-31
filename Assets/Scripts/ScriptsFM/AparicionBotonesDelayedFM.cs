using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AparicionBotonesDelayedFM : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public float delayTime = 3f; // Tiempo en segundos para el retraso

    void Start()
    {
        // Inicialmente, desactivamos los botones
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);

        // Iniciamos la corrutina para activar los botones después del retraso
        StartCoroutine(ShowButtonsWithDelay());
    }

    IEnumerator ShowButtonsWithDelay()
    {
        // Esperamos el tiempo especificado
        yield return new WaitForSeconds(delayTime);

        // Activamos los botones
        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
    }
}
