using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public Sprite blost;
    public Sprite bmid;
    public Sprite blow;


    Rigidbody2D m_Rigidbody;
    float m_Speed;

    SpriteRenderer WallRenderer;
    SpriteRenderer CuadroRenderer;
    SpriteRenderer MesaRenderer;
    SpriteRenderer BatteryRenderer;
    public float intentos = 3;

    // Start is called before the first frame update
    void Start()
    {
        WallRenderer = GameObject.Find("Background").GetComponent<SpriteRenderer>();
        CuadroRenderer = GameObject.Find("Cuadro").GetComponent<SpriteRenderer>();
        MesaRenderer = GameObject.Find("Mesas").GetComponent<SpriteRenderer>();
        BatteryRenderer = GameObject.Find("battery").GetComponent<SpriteRenderer>();
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
                if (intentos == 3)
                {
                    BatteryRenderer.sprite=blost;
                }
                if (intentos == 2)
                {
                    BatteryRenderer.sprite=bmid;
                }
                if (intentos == 1)
                {
                    BatteryRenderer.sprite=blow;
                }
                intentos = intentos - 1;
            }
            else 
            {
                SceneManager.LoadScene("Perder");
            }  
        }

       

    }

     void OnTriggerEnter2D(Collider2D col)
     {
        
        WallRenderer.sprite= bg1;
        transform.position = new Vector3(-10,-3,0);
     }


}
