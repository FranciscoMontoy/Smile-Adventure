using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextAndButtonControllerFM : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public List<Button> buttons;
    public float typingSpeed = 0.05f;

    private string fullText;

    void Start()
    {
        fullText = textMeshPro.text;
        textMeshPro.text = "";
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        foreach (char c in fullText)
        {
            textMeshPro.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }

        ShowButtons();
    }

    void ShowButtons()
    {
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }
}
