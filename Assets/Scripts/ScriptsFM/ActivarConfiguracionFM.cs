using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarConfiguracionFM : MonoBehaviour
{
    public GameObject PantallaUno;
    public GameObject PantallaDos;
    public GameObject negro;
    public Animator Fundido;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void CambioPantalla()
    {
        PantallaUno.SetActive(false);
        negro.SetActive(true);
        Fundido.Play("FundidoNegroRevesAnimationFM");
        PantallaDos.SetActive(true);
    }
}
