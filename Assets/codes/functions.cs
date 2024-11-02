using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTable : MonoBehaviour
{
    int Multiply(int c, int d)
    {
        return c * d;
    }
    void Start()
    {
        int num = 5; 

        for (int i = 1; i <= 10; i++)
        {
            int result = Multiply(num, i); 
            Debug.Log(num + " x " + i + " = " + result); 
        }
    }
}
