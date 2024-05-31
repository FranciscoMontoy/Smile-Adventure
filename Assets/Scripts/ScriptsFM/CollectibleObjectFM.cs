using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleObjectFM : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called");  // Verificar si OnTriggerEnter se llama
        if (other.CompareTag("PacMan"))
        {
            Debug.Log("PacMan collided");  // Verificar si la etiqueta es "PacMan"
            ObjetoCollectorFM objectCollector = FindObjectOfType<ObjetoCollectorFM>();
            if (objectCollector != null)
            {
                Debug.Log("Object Collector found");  // Verificar si encuentra el objeto collector
                objectCollector.CollectObject();
            }
            Destroy(gameObject);
        }
    }
}
