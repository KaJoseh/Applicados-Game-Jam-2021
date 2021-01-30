using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class GenerarSalas : MonoBehaviour
{
    [SerializeField] private List<Sprite> spritesPared;
    [SerializeField] private List<Sprite> spritesMesa;
    [SerializeField] private List<Sprite> spritesCuadro;

    [SerializeField] private GameObject pared;
    [SerializeField] private GameObject mesa;
    [SerializeField] private GameObject cuadro;



    private int contador= 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //DefinirSala();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    void DefinirSala()
    {
        Sala salaCorrecta = FindObjectOfType<SalaCorrecta>().salaCorrecta;
        if (contador <= 10)
        {
            Sala salaTemporal = new Sala(); 
                    
                Sprite spritePared = spritesPared[Random.Range(0, spritesPared.Count - 1)];
                pared.GetComponent<SpriteRenderer>().sprite = spritePared;
                salaTemporal.pared = spritePared;
                    
                Sprite spriteMesa = spritesMesa[Random.Range(0, spritesMesa.Count - 1)];
                mesa.GetComponent<SpriteRenderer>().sprite = spriteMesa;
                salaTemporal.mesa = spriteMesa;
                    
                Sprite spriteCuadro = spritesCuadro[Random.Range(0, spritesCuadro.Count - 1)];
                cuadro.GetComponent<SpriteRenderer>().sprite = spriteCuadro;
                salaTemporal.cuadro = spriteCuadro;
            
                if (!salaTemporal.Equals(salaCorrecta))
                {
                    contador++;
                }

        }
        else
        {
            pared.GetComponent<SpriteRenderer>().sprite = salaCorrecta.pared;
            mesa.GetComponent<SpriteRenderer>().sprite = salaCorrecta.mesa;
            cuadro.GetComponent<SpriteRenderer>().sprite = salaCorrecta.cuadro;
        }
        
       

    }
}
