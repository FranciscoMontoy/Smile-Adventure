using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefinitiveCollectibleObjectFM : MonoBehaviour
{
    [SerializeField] private ObjetoCollectorFM manager; // Referencia al script de gestión de recolección

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que ha entrado en el trigger es el jugador
        if (other.CompareTag("PacMan"))
        {
            Collect();
        }
    }

    private void Collect()
    {
        // Notifica al manager que se ha recolectado un objeto
        manager.CollectObject();

        // Aquí puedes añadir efectos visuales o sonoros

        // Desactiva o destruye el objeto recolectado
        Destroy(gameObject);
    }
}
