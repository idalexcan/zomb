using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour
{
    public GameObject body;
    public static GameObject[] zombies, citizens;
    
    void Start()
    {
        int limit = Random.Range(9, 21), cantZ=Random.Range(1,limit-1);
        zombies = new GameObject[cantZ];
        citizens = new GameObject[limit-cantZ];

        Debug.Log("zombies:"+zombies.Length);
        Debug.Log("citizen:" + citizens.Length);

        for (int i = 0; i < zombies.Length; i++)
        {
            zombies[i] = GameObject.Instantiate(body) as GameObject;
            zombies[i].transform.position = new Vector3(Random.Range(2, 50), 0, Random.Range(2, 50));
            zombies[i].AddComponent<Zombies>();
            zombies[i].GetComponent<Zombies>().zombie.col = Zombies.zCol[Random.Range(0, 3)]; ;
            zombies[i].GetComponent<Zombies>().zombie.taste = Zombies.zTaste[Random.Range(0, 5)];
            zombies[i].GetComponent<MeshRenderer>().material.color = zombies[i].GetComponent<Zombies>().zombie.col;
             
        }//genera los zombies

        for (int i = 0; i < citizens.Length; i++)
        {
            citizens[i] = GameObject.Instantiate(body) as GameObject;
            citizens[i].transform.position = new Vector3(Random.Range(0, 25), 0, Random.Range(0, 25));
            citizens[i].AddComponent<Citizen>();
            citizens[i].GetComponent<Citizen>().citizen.age = Random.Range(15, 101);
            citizens[i].GetComponent<Citizen>().citizen.name = Citizen.cNames[Random.Range(0, 20)];
        }//genera los ciudadanos

        StartCoroutine("AzarMoveVar");
    }

    void Update()
    {
        for (int i = 0; i < zombies.Length; i++)
        {
            Zombies.ZombMove(zombies[i], zombies[i].GetComponent<Zombies>().state);
        }
    }

    IEnumerator AzarMoveVar()
    {
        for (; ; )
        {
            for (int i = 0; i < zombies.Length; i++)
            {
                zombies[i].GetComponent<Zombies>().state=1; //Random.Range(0, 2)
                zombies[i].GetComponent<Zombies>().zombie.rotY = (Random.Range(0, 360));
                yield return new WaitForSeconds(5);
            }
        }
    }
    

}


//void Update()
//{
//    for (int i = 0; i < zombies.Length; i++)
//    {
//        ToMoving(zombies[i], zombies[i].GetComponent<Zombies>().zombie.moveStatus);
//    }
//}

//IEnumerator AzarMoveVar()
////
//{
//    for (; ; )
//    {
//        for (int i = 0; i < zombies.Length; i++)
//        {
//            zombies[i].GetComponent<Zombies>().zombie.moveStatus = Random.Range(1, 9);
//            yield return new WaitForSeconds(1.5f);
//        }
//    }
//}
//void ToMoving(GameObject zomBody, int dir)
//{
//    switch (dir)
//    {
//        case 1:
//            zomBody.transform.position += zomBody.transform.forward * 0.2f;
//            break;
//        case 2:
//            zomBody.transform.position -= zomBody.transform.forward * 0.2f;
//            break;
//        case 3:
//            zomBody.transform.position += zomBody.transform.right * 0.2f;
//            break;
//        case 4:
//            zomBody.transform.position -= zomBody.transform.right * 0.2f;
//            break;
//        default:
//            break;
//    }
//}

