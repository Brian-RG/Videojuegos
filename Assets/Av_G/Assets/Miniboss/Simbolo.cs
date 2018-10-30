using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simbolo {
    private string nombre;

    public string Nombre{
        private set
        {
            nombre = value;
        }
        get
        {
            return nombre;
        }
    }//cierra setter y getter nombre

    public Simbolo(string nombre)
    {
        Nombre = nombre;
    }

	
}
