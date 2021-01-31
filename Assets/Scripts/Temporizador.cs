using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temporizador : MonoBehaviour
{
    
    [SerializeField] private  float tiempoLimite = 1;
    private float tiempoRestante = 0;
    private bool  timerActivado = false;
    
    // Start is called before the first frame update
    void Start()
    {
        tiempoRestante = tiempoLimite;
        timerActivado = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerActivado){
            //Debug.Log(tiempoRestante.ToString());
            if(tiempoRestante > 0){
                tiempoRestante -= Time.deltaTime;
            }else{
                Debug.Log("Se acabó el tiempo");
                timerActivado = false;
                FindObjectOfType<Jugador>().GetComponent<Jugador>().intentos--;
                //ReiniciarTiempo();
            }
	
        }
    }
    
    void ReiniciarTiempo()
    {
        tiempoRestante = tiempoLimite;
        timerActivado = true;
    }
}
