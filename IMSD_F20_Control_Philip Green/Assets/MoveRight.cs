using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public Transform myTransform;
    
    
    public float speed;

   // private float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        myTransform.position = new Vector3(5,0, 0);
    }

    // Update is called once per frame
    void Update()
    {
         myTransform.position = 
          myTransform.position + new Vector3(-10, 0, 0) * speed * Time.deltaTime;

       


    }
}
