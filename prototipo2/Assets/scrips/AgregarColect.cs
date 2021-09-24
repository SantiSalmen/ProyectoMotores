using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregarColect : MonoBehaviour
{

    public int Puntaje = 1;

   

    void OnDestroy()
    {
        Contador.Colect += Puntaje;
       
    }
  
}
