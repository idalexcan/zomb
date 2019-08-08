using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour
{
    public GameObject body;
    sZombie[] zombies;
    void Start()
    {
        zombies = new sZombie[3];//Random.Range(2, 10)
        for (int i = 0; i < zombies.Length; i++)
        {
            zombies[i] = zombies[0];
            zombies[i].body = GameObject.Instantiate(body) as GameObject;
            zombies[i].body.transform.position = new Vector3(Random.Range(2, 10), 0, Random.Range(2, 10));
            zombies[i].body.GetComponent<MeshRenderer>().material.color = Data.zCol[Random.Range(0, 2)];
            zombies[i].gusto = Data.zTaste[Random.Range(0, 5)];
            Debug.Log("soy un zombie y me gustan " + zombies[i].gusto);
        }
    }
    
    void Update()
    {
        
    }

    
}


public struct sZombie
{
    public Color col;
    public string gusto; 
    public GameObject body; 
}

public struct sCitizen
{

}
