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
        // Guardar la posici�n original del bot�n y del fondo
        posicionOriginalBoton = transform.localPosition;
        posicionOriginalFondo = fondo.localPosition;
    }

    // M�todo llamado cuando el rat�n entra en el �rea del bot�n
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Desplazar el bot�n y el fondo en diagonal
        transform.localPosition = posicionOriginalBoton + desplazamiento;
        fondo.localPosition = posicionOriginalFondo + desplazamiento;
    }

    // M�todo llamado cuando el rat�n sale del �rea del bot�n
    public void OnPointerExit(PointerEventData eventData)
    {
        // Restaurar la posici�n original del bot�n y del fondo
        transform.localPosition = posicionOriginalBoton;
        fondo.localPosition = posicionOriginalFondo;
    }
}
