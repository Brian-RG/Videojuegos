using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Estado{
    private string nombre;
    private Dictionary<Simbolo, Estado> transicion;
    private Type tipo;

    public string Nombre
    {
        get
        {
            return nombre;
        }
        private set
        {
            nombre = value;
        }
    }

    public Type Tipo
    {
        get
        {
            return tipo;
        }
        private set
        {
            tipo = value;
        }
    }

    public Estado(string nombre, Type tipo)
    {
        Nombre = nombre;
        Tipo = tipo;
        transicion = new Dictionary<Simbolo, Estado>();
    }

    public void definirTransicion(Simbolo simbolo, Estado estado)
    {
        transicion.Add(simbolo, estado);
    }

    public Estado aplicarSimbolo(Simbolo simbolo)
    {
        if (transicion.ContainsKey(simbolo)){
            return transicion[simbolo];
        }
        return this;
    }

}
