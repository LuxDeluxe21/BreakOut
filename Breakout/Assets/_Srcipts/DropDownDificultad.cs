using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownDificultad : MonoBehaviour
{
    public Opciones opciones;
    private Dropdown dificultad;

    // Start is called before the first frame update
    void Start()
    {
        dificultad = GetComponent<Dropdown>();
        dificultad.value = (int)opciones.NivelDificultad;
        dificultad.onValueChanged.AddListener(delegate { opciones.CambiarDificultad(dificultad.value); });

    }
}
