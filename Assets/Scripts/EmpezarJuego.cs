using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpezarJuego : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip sonidoAceptar;

    private bool sonar;

    [SerializeField] private GameObject jugador;
    [SerializeField] private GameObject instruccion;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        sonar = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2"))
        {
            Empezar();
            if (sonar)
            {
                audioSource.clip = sonidoAceptar;
                audioSource.Play();
                sonar = false;
            }
        }
    }

    void Empezar()
    {
        instruccion.SetActive(false);
        jugador.GetComponent<Jugador>().enabled = true;
    }
}
