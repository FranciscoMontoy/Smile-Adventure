using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControllerGameOverFM : MonoBehaviour
{
    [SerializeField] Animator SceneTransitionAnimatorFM;
    [SerializeField] float transitionDuration = 1.0f; //Duración de la transición.
    [SerializeField] Canvas transitionCanvas;
    [SerializeField] GameObject Boton1;
    [SerializeField] GameObject Boton2;
    private bool firstLoad = true;
    public void OnLoadSceneButtonClicked(string sceneName)
    {
        StartCoroutine(LoadLevel(sceneName));
    }

    public void OnExitButtonClicked(string sceneName)
    {
        StartCoroutine(LoadLevel(sceneName));
    }

    private void Salir()
    {
        Application.Quit();
    }

    private IEnumerator LoadLevel(string sceneName)
    {
        Boton1.SetActive(false);
        Boton2.SetActive(false);
        transitionCanvas.enabled = true;
        SceneTransitionAnimatorFM.SetTrigger("End");
        yield return new WaitForSeconds(transitionDuration);
        var asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        SceneTransitionAnimatorFM.SetTrigger("Start");
        yield return new WaitForSeconds(transitionDuration);
        transitionCanvas.enabled = false; //Se desactiva el canvas.
        Boton1.SetActive(true);
        Boton2.SetActive(true);
    }

    private void Start()
    {
        if (!firstLoad)
        {
            transitionCanvas.enabled = true;
            SceneTransitionAnimatorFM.SetTrigger("Start");
            StartCoroutine(DisableCanvasAfterTransition());
        }
        firstLoad = false;
    }

    private IEnumerator DisableCanvasAfterTransition()
    {
        yield return new WaitForSeconds(transitionDuration);
        transitionCanvas.enabled = false;
    }
}
