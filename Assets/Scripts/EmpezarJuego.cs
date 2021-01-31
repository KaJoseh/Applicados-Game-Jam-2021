using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpezarJuego : MonoBehaviour
{
    [SerializeField] private GameObject jugador;

    [SerializeField] private GameObject instruccion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2"))
        {
            Empezar();
        }
    }

    void Empezar()
    {
        instruccion.SetActive(false);
        jugador.GetComponent<Jugador>().enabled = true;
    }
}
