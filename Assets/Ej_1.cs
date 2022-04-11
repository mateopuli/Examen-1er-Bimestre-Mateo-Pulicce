using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_1 : MonoBehaviour
{
    public string codigo;
    public int estadia;
    // Start is called before the first frame update
    void Start()
    {
        int pesoalimentoG;
        pesoalimentoG = estadia * 300;
        int pesoalimentoP;
        pesoalimentoP = estadia * 400;
        int pesoalimentoPG;
        pesoalimentoPG = estadia * 700;

        if (codigo == "G")
        {
            Debug.Log("Para ese periodo se necesitan " + pesoalimentoG + " gramos de alimento");
        }
        else if (codigo == "P")
        {
            Debug.Log("Para ese periodo se necesitan " + pesoalimentoP + " gramos de alimento");
        }
        else if (codigo == "PG")
        {
            Debug.Log("Para ese periodo se necesitan " + pesoalimentoPG + " gramos de alimento");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
