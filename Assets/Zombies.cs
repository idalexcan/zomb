using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    public enum State
    {
        idle,
        move
    }

    public static Color[] zCol;
    public static string[] zTaste;
    public DataZombies zombie=new DataZombies();
    public State state;

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
            "aparatos reproductores"
        };
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public static void ZombMove(GameObject zombie, State s)
    {
        switch (s)
        {
            case State.idle:
                Debug.Log("move");
                break;
            case State.move:
                Debug.Log("move");
                float dir = zombie.GetComponent<Zombies>().zombie.rotY;
                zombie.transform.position += zombie.transform.forward;
                break;
            default:
                break;
        }
    }

    //IEnumerator AzarDir()
    //{
        
    //    for (;;)
    //    {
    //        for (int i = 0; i < General.zombies.Length; i++)
    //        {
    //            General.zombies[i].GetComponent<Zombies>().zombie.moveStatus=
    //        }
    //    }
    //}
}

public struct DataZombies
{
    public Color col;
    public string taste;
    public float rotY;
}

