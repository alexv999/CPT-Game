using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BubbleSortScript : MonoBehaviour
{
    public static void Main(string[] args)
    { 
        int[] a = { 1, 0, 2, 3 }; // array example
        int t; // temp num
        
        for (int p = 0; p <= a.Length - 2; p++) // outer loop for repetition
        {
            for (int i = 0; i <= a.Length - 2; i++) // inner loop for swapping
            {
                if (a[i] > a[i + 1]) // check
                {
                    t = a[i + 1]; // swap
                    a[i + 1] = a[i];
                    a[i] = t;
                }
            } 
        }


    }

    //public int topUpgrade = a[a.Length];
}
