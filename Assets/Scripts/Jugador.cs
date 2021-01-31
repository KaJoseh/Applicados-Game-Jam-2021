using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
 
    public Sprite blost;
    public Sprite bmid;
    public Sprite blow;


    Rigidbody2D m_Rigidbody;
    [SerializeField] private float velocidadInicial;
    private float m_Speed;
    private Temporizador tiempo;
    
    SpriteRenderer BatteryRenderer;
    private Sala salaActual = new Sala();
    public float intentos = 3;
    public float tiempoDeEspera = 2;

    // Start is called before the first frame update
    void Start()
    {
        BatteryRenderer = GameObject.Find("battery").GetComponent<SpriteRenderer>();
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody2D>();
        //Set the speed of the GameObject
        m_Speed = velocidadInicial;
        tiempo = FindObjectOfType<Temporizador>();

    }

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.velocity = transform.right * m_Speed;

        
        
        if (intentos>0)
        {
            if (intentos == 3)
            {
                BatteryRenderer.sprite=blost;
            }
            else if (intentos == 2)
            {
                BatteryRenderer.sprite=bmid;
            }
            else if (intentos == 1)
            {
                BatteryRenderer.sprite=blow;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                PresionarQ();
            }
            if (Input.GetButtonDown("Fire2"))
            {
                PresionarE();
            }
        }
        else 
        {
            SceneManager.LoadScene("Perder");
        }  
        

    }
    //Selecciona que la sala no es correcta
    void PresionarQ()
    {
        Sala salaCorrecta = FindObjectOfType<SalaCorrecta>().salaCorrecta;
        //Dice que la sala correcta es incorrecta
        if (salaActual.Equals(salaCorrecta))
        {
            Debug.Log("wrong");
            
            intentos = intentos--;
        }
        //la sala es incorrecta
        else
        {
            Debug.Log("Siguiente Sala");
            //Pasar a la siguiente sala
        }
    }

    //Dice que la sala es correcta
    void PresionarE()
    {
        Sala salaCorrecta = FindObjectOfType<SalaCorrecta>().salaCorrecta;
        //Dice que la sala correcta es correcta
        if (salaActual.Equals(salaCorrecta))
        {
           //Va a escena de ganar
           Debug.Log("Escena de ganar");
        }
        else
        {
            Debug.Log("wrong");
           
            intentos--;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.tag == "Sala")
        {
            salaActual = col.GetComponent<GenerarSalas>().salaTemporal;
            Debug.Log(col.name);
        }
        if (col.tag== "Puerta")
        {
            Debug.Log("Puerta");
            m_Speed = 0;
            FindObjectOfType<moverSalas>().called = true;
            Invoke("Waiting", tiempoDeEspera);
            
        }
        
    }

    void Waiting()
    {
        m_Speed = velocidadInicial;
        tiempo.ReiniciarTiempo();
    }
}