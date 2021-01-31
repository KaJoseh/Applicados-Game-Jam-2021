using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class pasarDialogo : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public string string1, string2, string3, string4;
    public KeyCode teclaPasarDialogo;

    Scene escenaActual;
    int numeroTexto;
    SceneChanger sc;

    // Start is called before the first frame update
    void Start()
    {
        numeroTexto = 1;
        sc = GetComponent<SceneChanger>();
    }

    // Update is called once per frame
    void Update()
    {
        escenaActual = SceneManager.GetActiveScene();


        if (Input.GetKeyDown(teclaPasarDialogo) && numeroTexto == 1)
        {
            numeroTexto = 2;
        }
        else if(Input.GetKeyDown(teclaPasarDialogo) && numeroTexto == 2)
        {
            numeroTexto = 3;
        }
        else if (Input.GetKeyDown(teclaPasarDialogo) && numeroTexto == 3)
        {
            numeroTexto = 4;
        }
        else if (Input.GetKeyDown(teclaPasarDialogo) && numeroTexto == 4)
        {
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
