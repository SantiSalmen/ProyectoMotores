using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<PlayerController2>().SendMessage("Recolocar");
    }
}
