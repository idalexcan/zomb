using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControl : MonoBehaviour
{
    public static Vector3 pos;

    public static float speed = 4;
    bool canJump = false;

    void Start()
    {
        GetComponent<MeshRenderer>().material.color = Color.black;

        
    }
    void Update()
    {
        transform.eulerAngles = new Vector3(0, FPSim.rotY, 0);
        if (Input.GetKey("w")) { transform.position += transform.forward * (speed / 20); }
        if (Input.GetKey("s")) { transform.position -= transform.forward * (speed / 20); }
        if (Input.GetKey("d")) { transform.position += transform.right * (speed / 20); }
        if (Input.GetKey("a")) { transform.position -= transform.right * (speed / 20); }
        pos = transform.position;

        if ((Input.GetKeyDown(KeyCode.Space)) && (canJump))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        canJump = true;
        if (col.gameObject.GetComponent<Zombies>())
        {
            Debug.Log("aiguantuvreikcfri");
        }
        else if (col.gameObject.GetComponent<Citizen>())
        {
            Debug.Log("sdagsdyjahygwdhygsa iwachu");
        }
    }
}
