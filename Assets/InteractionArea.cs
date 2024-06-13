using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionArea : MonoBehaviour
{
    public Text txtPuntaje;
    int puntaje = 0;

    void Start()
    {
        txtPuntaje.text = "Puntaje: " + puntaje.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Obtener nombre de objeto colisionado
        Debug.Log("Hubo colision con " + other.name);
        puntaje += other.gameObject.GetComponent<PickupScript>().valor;
        txtPuntaje.text = "Puntaje: " + puntaje.ToString();
        if (other.gameObject.GetComponent<PickupScript>().alimento)
        {
            Destroy(other.gameObject);
        }
    }
}
