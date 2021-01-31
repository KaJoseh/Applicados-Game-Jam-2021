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
    public Sala salaTemporal = new Sala();
    private Sala salaCorrecta;
    
    // Start is called before the first frame update
    void Start()
    {
        salaCorrecta = FindObjectOfType<SalaCorrecta>().salaCorrecta;
        DefinirSala();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    

    public void DefinirSala()
    {
        
        if (contador < 5)
        {
                Sprite spritePared = spritesPared[Random.Range(0, spritesPared.Count )];
                pared.GetComponent<SpriteRenderer>().sprite = spritePared;
                salaTemporal.pared = spritePared;
                    
                Sprite spriteMesa = spritesMesa[Random.Range(0, spritesMesa.Count )];
                mesa.GetComponent<SpriteRenderer>().sprite = spriteMesa;
                salaTemporal.mesa = spriteMesa;
                    
                Sprite spriteCuadro = spritesCuadro[Random.Range(0, spritesCuadro.Count )];
                cuadro.GetComponent<SpriteRenderer>().sprite = spriteCuadro;
                salaTemporal.cuadro = spriteCuadro;
            
                if (!salaTemporal.Equals(salaCorrecta))
                {
                    contador++;
                    Debug.Log(contador.ToString());
                }

        }
        else
        {
            pared.GetComponent<SpriteRenderer>().sprite = salaCorrecta.pared;
            mesa.GetComponent<SpriteRenderer>().sprite = salaCorrecta.mesa;
            cuadro.GetComponent<SpriteRenderer>().sprite = salaCorrecta.cuadro;

            salaTemporal = salaCorrecta;
            
            Debug.Log("Legó a 5 ");
            
            Debug.Log("SAla correcta " + salaCorrecta.pared.name + salaCorrecta.mesa.name + salaCorrecta.cuadro.name);

        }
        
        Debug.Log(salaTemporal.pared.name+ salaTemporal.mesa.name + salaTemporal.cuadro.name);
       

    }
}
