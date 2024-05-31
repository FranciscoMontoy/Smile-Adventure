using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDamageFM : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el objeto con el que colisionamos tiene el script SistemaDeVidas
        SistemaVidasFM sistemaDeVidas = collision.gameObject.GetComponent<SistemaVidasFM>();

        if (sistemaDeVidas != null)
        {
            // Llamar al método para reducir la vida
            sistemaDeVidas.RecibirDanio();
        }
    }
}
