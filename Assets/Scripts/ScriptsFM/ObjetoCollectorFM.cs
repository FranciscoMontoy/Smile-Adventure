using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ObjetoCollectorFM : MonoBehaviour
{
    [SerializeField] private int objectsToCollect = 4; // Cantidad de objetos necesarios para cambiar de escena
    [SerializeField] private string nextSceneName = "1�FinalNivelFM"; // Nombre de la escena a cargar
    [SerializeField] private TextMeshProUGUI objectsRemainingText; // Referencia al componente de texto UI
    private int objectsCollected = 0;

    private void Start()
    {
        UpdateObjectsRemainingText();
    }

    // M�todo para llamar cuando se recolecta un objeto
    public void CollectObject()
    {
        objectsCollected++;

        // Verifica si se han recolectado suficientes objetos
        if (objectsCollected >= objectsToCollect)
        {
            LoadNextScene();
        }
        else
        {
            UpdateObjectsRemainingText();
        }
    }

    // M�todo para cargar la siguiente escena
    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    // M�todo para actualizar el texto de objetos restantes
    private void UpdateObjectsRemainingText()
    {
        int objectsRemaining = objectsToCollect - objectsCollected;
        objectsRemainingText.text = "Objetos restantes: " + objectsRemaining;
    }
}
