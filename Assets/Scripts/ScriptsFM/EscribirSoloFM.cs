using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscribirSoloFM : MonoBehaviour
{
    public string frase = "Antes de comenza tu aventura necesito saber quien eres";
    public Text texto;

    void Start()
    {
        StartCoroutine(Reloj());
    }

    IEnumerator Reloj()
    {
        foreach (char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
