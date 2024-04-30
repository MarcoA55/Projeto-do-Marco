using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Diagnostics.DebuggerDisplay("{" + nameof(DebuggerDisplay ) + "(),nq}")]
public class teste4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int number = -10;

        if (number > 0)
        { 
            Debug.Log("O número é maior que zero.");
        }
        else 
        { 
            Debug.Log("O número não é maior que zero");
        }
     }
    // Update is called once per frame
    void Update()
    {
        
    }

    public override bool Equals(object obj)
    {
        return obj is teste4 teste &&
               base.Equals(obj) &&
               DebuggerDisplay == teste.DebuggerDisplay;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), DebuggerDisplay);
    }

    private string DebuggerDisplay => ToString();
}
