using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    int count = 0;
    void OnCollisionEnter(Collision collision)
    {
        count++;
        print(count);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
