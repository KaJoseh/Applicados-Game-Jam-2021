using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalHaciaMenu : MonoBehaviour
{
    public AudioClip sonidoPasar, sonidoEmpezar;
    [Space]
    public KeyCode teclaPasarDialogo;

    Scene escenaActual;
    SceneChanger sc;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        sc = GetComponent<SceneChanger>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = sonidoEmpezar;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(teclaPasarDialogo))
        {
            audioSource.Play();
            sc.enabled = true;
        }
    }
}
