using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    public sZombie[] zombies;

    public Zombies(int cantZ)
    {
        zombies = new sZombie[cantZ];
    }

    public void Create(sZombie zombie, int index, GameObject bodyref)
    {
        zombies[index] = zombie;
        zombies[index].body = GameObject.Instantiate(bodyref) as GameObject;
        zombies[index].body.transform.position = new Vector3(Random.Range(2, 10), 0, Random.Range(2, 10));
        zombies[index].body.GetComponent<MeshRenderer>().material.color = zombies[index].col;
        zombies[index].body.transform.name="zombi";
    }

    void Update()
    {
        
    }
}
public struct sZombie 
{
    public Color col;
    public string taste;
    public GameObject body;
    public string bodyType;
}
