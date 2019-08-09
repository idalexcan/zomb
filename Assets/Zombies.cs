using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    public static Color[] zCol;
    public static string[] zTaste;
    public sBody zombie=new sBody();

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
            "los páncreas",
            "los cerebro",
            "los hígados",
            "los tumores, o pulmones asmáticos o riñones con cálculos",
            "los aparatos reproductores, xx, xy o lo que sea xd"
        };
    }
    //public void AddData()
    //{
        
    //}

}



//public class Zombies : MonoBehaviour
//{
//    public GameObject[] zombies;
//    sBody zAtributes;

//    public Zombies(int cantZ, GameObject bodyref)
//    {
//        zombies = new GameObject[cantZ];
//        for (int i = 0; i < cantZ; i++)
//        {
//            zombies[i] = GameObject.Instantiate(bodyref) as GameObject;
//            zombies[i].transform.position = new Vector3(Random.Range(2, 10), 0, Random.Range(2, 10));
//            zombies[i].GetComponent<MeshRenderer>().material.color = Data.zCol[Random.Range(0, 3)];
//            zombies[i].AddComponent<Zombies>();
//            zombies[i].GetComponent<Zombies>().zAtributes.taste = Data.zTaste[Random.Range(0, 6)];
//        }
//    }

//    void Update()
//    {

//    }

//}
