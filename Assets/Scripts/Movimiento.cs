using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    float m_Speed;

    public float intentos = 3;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody2D>();
        //Set the speed of the GameObject
        m_Speed = 3.0f;

    }

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.velocity = transform.right * m_Speed;

        if (Input.GetKeyDown("q"))
        {
            if (intentos>0)
            {
            Debug.Log("right or wrong");
            intentos = intentos - 1;
            }
            else 
            {
                Destroy(gameObject);
            }  
        }

       

    }

     void OnTriggerEnter2D(Collider2D col)
     {
        
     }


}
