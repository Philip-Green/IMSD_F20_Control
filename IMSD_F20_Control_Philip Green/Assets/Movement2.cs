using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public Transform myTransform;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myTransform.position = new Vector3(-10, myTransform.position.y, 0);
        //timer = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position += new Vector3(1, 0, 0); 
    }
}
