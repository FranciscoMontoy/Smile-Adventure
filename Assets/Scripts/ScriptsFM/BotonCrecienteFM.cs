using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BotonCrecienteFM : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public RectTransform fondo; // Asigna el RectTransform del fondo en el inspector
    private Vector3 posicionOriginalBoton;
    private Vector3 posicionOriginalFondo;

    // Desplazamiento en diagonal
    public Vector3 desplazamiento = new Vector3(-10f, 10f, 0f);

    void Start()
    {
        // Guardar la posición original del botón y del fondo
        posicionOriginalBoton = transform.localPosition;
        posicionOriginalFondo = fondo.localPosition;
    }

    // Método llamado cuando el ratón entra en el área del botón
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Desplazar el botón y el fondo en diagonal
        transform.localPosition = posicionOriginalBoton + desplazamiento;
        fondo.localPosition = posicionOriginalFondo + desplazamiento;
    }

    // Método llamado cuando el ratón sale del área del botón
    public void OnPointerExit(PointerEventData eventData)
    {
        // Restaurar la posición original del botón y del fondo
        transform.localPosition = posicionOriginalBoton;
        fondo.localPosition = posicionOriginalFondo;
    }
}
