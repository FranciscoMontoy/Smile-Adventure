using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SonidoEntreEscenasFM : MonoBehaviour
{
    private static SonidoEntreEscenasFM instance;
    public static SonidoEntreEscenasFM Instance
    {
        get
        {
            return instance;
        }
    }

    [SerializeField] private string sceneName1 = "PantallaInicio"; // Reemplaza con el nombre de la primera escena permitida
    [SerializeField] private string sceneName2 = "Pantalla Inicio 2"; // Reemplaza con el nombre de la segunda escena permitida

    private AudioSource audioSource;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();

        // Escuchar el evento de cambio de escena
        SceneManager.sceneLoaded += OnSceneLoaded;

        CheckMusicStatus();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        CheckMusicStatus();
    }

    private void CheckMusicStatus()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == sceneName1 || currentSceneName == sceneName2)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
