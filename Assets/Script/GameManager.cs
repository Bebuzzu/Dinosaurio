using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual;
    [SerializeField] public int puntuacionMaxima;
    [SerializeField] float tiempo;
    [SerializeField] GameObject gameOver, boton;
    [SerializeField] GameObject jugador, enemigo;
    [SerializeField] bool cronometro;
    [SerializeField] TMP_Text texto;
    public static GameManager Instancia;


    // Start is called before the first frame update
    void Start()
    {
        puntuacionMaxima = PlayerPrefs.GetInt("puntuacionMaxima");
        gameOver.SetActive(false);
        boton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (cronometro == true)
        {
            tiempo -= Time.deltaTime;
            int minutos = (int)tiempo / 60;
            int segundos = (int)tiempo % 60;
            Debug.Log(minutos + ":" + segundos);
            string textoTiempo = $"{minutos:D2}:{segundos:D2}";
            texto.text = textoTiempo;
        }
    }
    public void Perder()
    {
        jugador.SetActive(false);
        enemigo.SetActive(false);
        gameOver.SetActive(true);
        boton.SetActive(true);
        cronometro = false;
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
