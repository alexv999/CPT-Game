using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BinarySearchScript : MonoBehaviour
{
    public static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;


        while (right >= left)
        {
            int mid = (left + right) / 2;
            if (target > array[mid])
                left = mid + 1;
            else if (target < array[mid])
                right = mid - 1;
            else
                return mid;
        }
        return -1;
    }



}