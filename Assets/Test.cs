using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{

    void Start()
    {
        int[] points = { 50, 100, 150, 200, 250 };

        for (int i = 0; i < points.Length; i++)
        {

            Debug.Log(points[i]);
        }
        for (int i = 4; i >= 0; i--)
        {

            Debug.Log(points[i]);
        }



    }    



    // Update is called once per frame
    void Update()
    {
        
    }
}