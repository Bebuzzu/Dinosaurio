using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Texto : MonoBehaviour
{
    [SerializeField] TMP_Text puntuacionActual, mejorPuntuacion;
    [SerializeField] TMP_Text tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntuacionActual.text = GameManager.Instancia.puntuacionActual.ToString();
        mejorPuntuacion.text = GameManager.Instancia.puntuacionMaxima.ToString();
    }
}
