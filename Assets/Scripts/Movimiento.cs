using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Sprite bg1;
    public Sprite bg2;
    public Sprite bg3;
    public Sprite cuadro1;
    public Sprite cuadro2;
    public Sprite cuadro3;
    public Sprite mesa1;
    public Sprite mesa2;
    public Sprite mesa3;
    
    GameObject background;
    Rigidbody2D m_Rigidbody;
    float m_Speed;

    SpriteRenderer WallRenderer;
    SpriteRenderer CuadroRenderer;
    SpriteRenderer MesaRenderer;
    public float intentos = 3;

    // Start is called before the first frame update
    void Start()
    {
        WallRenderer = GameObject.Find("Background").GetComponent<SpriteRenderer>();
        CuadroRenderer = GameObject.Find("Cuadro").GetComponent<SpriteRenderer>();
        MesaRenderer = GameObject.Find("Mesas").GetComponent<SpriteRenderer>();
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
        
        WallRenderer.sprite= bg1;
        transform.position = new Vector3(-10,-3,0);
     }


}
