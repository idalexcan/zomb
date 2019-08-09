using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour
{
    //Data db = new Data();
    public GameObject body;
    //sBody atributes = new sBody();
    GameObject[] zombies, citizens;
    Zombies z;
    
    void Start()
    {
        
        zombies = new GameObject[Random.Range(0, 6)];
        citizens = new GameObject[Random.Range(0, 6)];

        for (int i = 0; i < zombies.Length; i++)//ZOMBIES

        {
            zombies[i] = GameObject.Instantiate(body) as GameObject;
            zombies[i].transform.position = new Vector3(Random.Range(2, 10), 0, Random.Range(2, 10));
            zombies[i].AddComponent<Zombies>().zombie.col = Zombies.zCol[Random.Range(0, 3)];
            zombies[i].AddComponent<Zombies>().zombie.taste = Zombies.zTaste[Random.Range(0, 5)];
            zombies[i].GetComponent<MeshRenderer>().material.color = zombies[i].GetComponent<Zombies>().zombie.col;
        }

        for (int i = 0; i < citizens.Length; i++)
        {
            citizens[i] = GameObject.Instantiate(body) as GameObject;
            citizens[i].transform.position = new Vector3(Random.Range(0, 10), 0, Random.Range(0, 10));
            citizens[i].AddComponent<Citizen>().citizen.age = Random.Range(15, 101);
            citizens[i].AddComponent<Citizen>().citizen.name = Citizen.cNames[Random.Range(0, 20)];
        }
    }
    
    void Update()
    {
        
    }
}



//public class General : MonoBehaviour
//{
//    //Data db = new Data();
//    public GameObject body;
//    sZombie[] zombies;

//    void Start()
//    {

//        zombies = new sZombie[3];//Random.Range(2, 10)
//        for (int i = 0; i < zombies.Length; i++)
//        {
//            zombies[i] = zombies[0];
//            zombies[i].body = GameObject.Instantiate(body) as GameObject;
//            zombies[i].body.transform.position = new Vector3(Random.Range(2, 10), 0, Random.Range(2, 10));
//            zombies[i].body.GetComponent<MeshRenderer>().material.color = Data.zCol[Random.Range(0, 3)];
//            zombies[i].gusto = Data.zTaste[Random.Range(0, 6)];
//            Debug.Log("soy un zombie y me gustan " + zombies[i].gusto);
//            zombies[i].bodyType = "zombi";
//        }
//    }

//    void Update()
//    {

//    }


//}
