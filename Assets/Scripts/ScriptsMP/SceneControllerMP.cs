using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{ // es una funcion dentro de un struc que sirve para cagar  la escenay luego poder salir//
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void salir()
    {
        Application.Quit();
    }
}
