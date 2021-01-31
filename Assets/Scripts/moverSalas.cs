using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverSalas : MonoBehaviour
{
    [SerializeField] private GameObject camara;
    [SerializeField] private GameObject sala1;
    [SerializeField] private GameObject sala2;
    
    Rigidbody2D m_Rigidbody;
    [SerializeField] private float velocidadInicial;
    private float m_Speed;

    private GameObject salaSiguiente;
    private bool distinguirSala = true;
    public bool called = false;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        //Set the speed of the GameObject
        m_Speed = velocidadInicial;
        salaSiguiente = sala2;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (called)
        {
            float posicionSala = salaSiguiente.transform.position.x;
            if (camara.transform.position.x <= posicionSala)
            {
                m_Speed = velocidadInicial;
                m_Rigidbody.velocity = transform.right * m_Speed;
            }
            else
            {
                camara.transform.position = new Vector3(posicionSala, 1, -10);
                m_Rigidbody.velocity = transform.right * 0;
                called = false;
                distinguirSala= !distinguirSala;
                cambiarSalaActual();
                salaSiguiente.transform.position = new Vector3(posicionSala + 14.45f, 0, 0);
                salaSiguiente.GetComponent<GenerarSalas>().DefinirSala();
                
            }
        }
    }
    
    public void cambiarSalaActual()
    {
        if (distinguirSala)
        {
            salaSiguiente = sala2;
        }
        else
        {
            salaSiguiente = sala1;
        }
            
        
            
    }
}
