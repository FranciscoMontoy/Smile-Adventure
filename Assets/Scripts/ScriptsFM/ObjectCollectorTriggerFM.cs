using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollectorTriggerFM : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PacMan"))
        {
            // Encuentra el ObjectCollector en la escena
            ObjetoCollectorFM objectCollector = FindObjectOfType<ObjetoCollectorFM>();
            if (objectCollector != null)
            {
                // Llama al método CollectObject para actualizar el contador
                objectCollector.CollectObject();
            }

            // Destruye el objeto recolectado
            Destroy(gameObject);
        }
    }
}