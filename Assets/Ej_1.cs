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

        int precioalimentoG;
        precioalimentoG = pesoalimentoG * 80;
        int precioalimentoP = pesoalimentoP * 80;
        int precioalimentoPG;
        precioalimentoPG = pesoalimentoPG * 80;

        if (codigo == "G")
        {
            Debug.Log("Para ese periodo se necesitan " + pesoalimentoG + " gramos de alimento");
            Debug.Log("El costo del alimento es de " +precioalimentoG+ " pesos");
        }
        else if (codigo == "P")
        {
            Debug.Log("Para ese periodo se necesitan " + pesoalimentoP + " gramos de alimento");
            Debug.Log("El costo del alimento es de " + precioalimentoP + " pesos");
        }
        else if (codigo == "PG")
        {
            Debug.Log("Para ese periodo se necesitan " + pesoalimentoPG + " gramos de alimento");
            Debug.Log("El costo del alimento es de " + precioalimentoPG + " pesos");
        }
        else
        {
            Debug.Log("Error! Lo ingresado no corresponde a un código.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
