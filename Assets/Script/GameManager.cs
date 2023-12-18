using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual;
    [SerializeField] public int puntuacionMaxima;
    [SerializeField] float tiempo;
    public static GameManager Instancia;

    // Start is called before the first frame update
    void Start()
    {
        puntuacionMaxima = PlayerPrefs.GetInt("puntuacionMaxima");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Perder()
    {

    }
    public void ReiniciarJuego()
    {

    }
    public void ActualizarPuntuación()
    {
        puntuacionActual += 1;
        if (puntuacionActual >= puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion", puntuacionMaxima);
        }
    }
}
