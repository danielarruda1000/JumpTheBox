using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DistanceCounter : MonoBehaviour
{
    public Text counterUi;
    public float distanceTotal;
    public float distanceIncrease;
    

    void Start()
    {
        
        distanceTotal = 0f;
        distanceIncrease = 10f;
    }

   
    void Update()
    {
        currentCount();
    }

    public void currentCount()
    {
        counterUi.text = (int)distanceTotal + "";
        distanceTotal += distanceIncrease * Time.deltaTime;
    }

}
