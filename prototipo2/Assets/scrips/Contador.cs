using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
   public static int Colect = 0;

    public string ColectString = "Esmealdas : ";

    public Text Colecto;

    public static Contador GameContoller;

    void Awake()
    {
        GameContoller = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Colecto != null)
        {
            Colecto.text = ColectString = Colect.ToString();
        }
    }
}
