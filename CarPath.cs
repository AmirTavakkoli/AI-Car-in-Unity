using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPath : MonoBehaviour
{
    public Transform[] nodes;
    public float speed;


    // Start is called before the first frame update
    void Start()
    { 
        
            transform.position = new Vector3(59, 1, -4.75f);
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
