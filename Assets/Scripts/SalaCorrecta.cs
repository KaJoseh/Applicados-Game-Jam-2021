using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalaCorrecta : MonoBehaviour
{
    [SerializeField] private List<Sprite> spritesPared;
    [SerializeField] private List<Sprite> spritesMesa;
    [SerializeField] private List<Sprite> spritesCuadro;
    
    public Sala salaCorrecta = new Sala();
    
    public void DefinirSalaCorrecta()
    {
        salaCorrecta.pared = spritesPared[Random.Range(0, spritesPared.Count )];
        salaCorrecta.mesa = spritesMesa[Random.Range(0, spritesMesa.Count )];
        salaCorrecta.cuadro = spritesCuadro[Random.Range(0, spritesCuadro.Count )];
    }
    
    void Start(){
        DefinirSalaCorrecta();
        Debug.Log(salaCorrecta.pared.name + salaCorrecta.mesa.name + salaCorrecta.cuadro.name);
    }
    
}
