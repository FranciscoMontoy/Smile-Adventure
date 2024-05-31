using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherFM : MonoBehaviour
{
    public string sceneToLoad;
    public int requiredClicks = 6;
    private int clickCount = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            clickCount++;
            if (clickCount > requiredClicks)
            {
                SceneManager.LoadScene(sceneToLoad);

            }
        }
    }
}
