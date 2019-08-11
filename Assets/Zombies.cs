using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    public static Color[] zCol;
    public static string[] zTaste;
    public DataZombies zombie=new DataZombies();

    private void Awake()
    {
        zCol = new Color[3] //registro de colores
        {
            Color.cyan,
            Color.magenta,
            Color.green
        };

        zTaste = new string[5]
        {
            "páncreas",
            "cerebro",
            "hígados",
            "tumores, o pulmones asmáticos o riñones con cálculos",
            "aparatos reproductores, xx, xy o lo que sea xd"
        };
    }
}

public struct DataZombies
{
    public Color col;
    public string taste;
    public int moveStatus;
}

