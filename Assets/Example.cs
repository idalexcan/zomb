using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    struct BoxParameters
    {
        public float width;
        public float height;
        public float depth;
        public Color color;
    }

    BoxParameters myParameters;
    void Start()
    {
        myParameters.width = 2;
        myParameters.height = 3;
        myParameters.depth = 4;
        myParameters.color = new Color(1, 0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        float h = (100 * Mathf.Sin(Time.fixedTime)/10);
        myParameters.height = h;
        UpdateBox(myParameters);
    }

    void UpdateBox(BoxParameters box)
    {
        Vector3 size = new Vector3(box.width, box.height, box.depth);
        transform.localScale = size;
        GetComponent<Renderer>().material.color = box.color;
    }
}
