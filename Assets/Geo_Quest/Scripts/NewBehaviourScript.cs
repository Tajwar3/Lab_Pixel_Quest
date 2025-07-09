using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private string var1 = "Hello";
    int var3 = 3;
    // Start is called before the first frame update
    void Start()
    {
        string var2 = "world";
        Debug.Log("Hello world");
        Debug.Log(var1 + var2);
     
    }

    // Update is called once per frame
    void Update()
    {
        int v = var3++;
        int message = v;
        Debug.Log(message);
       
    }
}

