using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour
{
    //Data db = new Data();
    public GameObject body;
    Zombies z;
    sZombie sz=new sZombie();
    

    void Start()
    {
        z = new Zombies(5);

        for (int i = 0; i < 3; i++)
        {
            sz.col = Data.zCol[0];
            sz.taste = Data.zTaste[0];
            z.Create(sz, i, body);
        }
    }
    
    void Update()
    {
        
    }
}




public struct sCitizen
{

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
