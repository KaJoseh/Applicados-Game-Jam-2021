using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class pasarDialogo : MonoBehaviour
{
    public AudioClip sonidoPasar, sonidoEmpezar;
    [Space]
    public TextMeshProUGUI texto;
    public string string1, string2, string3, string4;
    public KeyCode teclaPasarDialogo;
    private Sala descripcion;

    Scene escenaActual;
    int numeroTexto;
    SceneChanger sc;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        numeroTexto = 1;
        sc = GetComponent<SceneChanger>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = sonidoPasar;

        FindObjectOfType<SalaCorrecta>().DefinirSalaCorrecta();
        descripcion = FindObjectOfType<SalaCorrecta>().salaCorrecta;

        string3 = "Pared " + descripcion.pared.name +", Un cuadro de " + descripcion.cuadro.name + " y una mesa con " 
                  + descripcion.mesa.name + "...";
    }

    // Update is called once per frame
    void Update()
    {
        escenaActual = SceneManager.GetActiveScene();


        if (Input.GetKeyDown(teclaPasarDialogo) && numeroTexto == 1)
        {
            audioSource.Play();
            numeroTexto = 2;
        }
        else if(Input.GetKeyDown(teclaPasarDialogo) && numeroTexto == 2)
        {
            audioSource.Play();
            numeroTexto = 3;
        }
        else if (Input.GetKeyDown(teclaPasarDialogo) && numeroTexto == 3)
        {
            audioSource.Play();
            numeroTexto = 4;
        }
        else if (Input.GetKeyDown(teclaPasarDialogo) && numeroTexto == 4)
        {
            audioSource.clip = sonidoEmpezar;
            audioSource.Play();
            sc.enabled = true;
            print("CAMBIANDO ESCENA");
        }


        if (escenaActual.name == "introduccionNABO")
        {
            if(numeroTexto == 2)
            {
                texto.SetText(string2);
            }
            else if(numeroTexto == 3)
            {
                texto.SetText(string3);
            }
            else if (numeroTexto == 4)
            {
                texto.SetText(string4);
            }
        }

    }
}
