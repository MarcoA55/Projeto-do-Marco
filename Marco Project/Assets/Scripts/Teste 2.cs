using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 20;



        bool comp1 = a > b;
        Debug.Log("A > B? " + comp1);
        
        
        bool comp2 = a < b;
        Debug.Log("A < B? " + comp2);

        bool comp3 = a >= b;
        Debug.Log("A >= B? " + comp3);

        bool comp4 = a <= b;
        Debug.Log("A <= B " + comp4);

        bool comp5 = a == b;
        Debug.Log("A == B? " + comp5);
        
        bool comp6 = a != b;
        Debug.Log("A != B? " + comp6);
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
