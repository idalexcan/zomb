﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static Color[] zCol;
    public static string[] zTaste;
    void Start()
    {
        zCol = new Color[3] //registro de colores
        {
            Color.cyan,
            Color.magenta,
            Color.green
        };
        
        zTaste = new string[5]
        {
            "los páncreas",
            "los cerebro",
            "los hígados",
            "los tumores, o pulmones asmáticos o riñones con cálculos",
            "los aparatos reproductores, xx, xy o lo que sea xd"
        };
    }

    
    void Update()
    {
        
    }
}
