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
        salaCorrecta.pared = spritesPared[Random.Range(0, spritesPared.Count - 1)];
        salaCorrecta.mesa = spritesMesa[Random.Range(0, spritesMesa.Count - 1)];
        salaCorrecta.cuadro = spritesCuadro[Random.Range(0, spritesCuadro.Count - 1)];
    }
    
    void Start(){
        DefinirSalaCorrecta();
        Debug.Log(salaCorrecta.pared.ToString() + salaCorrecta.mesa.ToString() + salaCorrecta.cuadro.ToString());
    }
    
}
