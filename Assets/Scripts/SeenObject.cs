using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeenObject : MonoBehaviour, iGazeReceiver
{
    private bool isGazingUpon; 

    // Update is called once per frame
    void Update()
    {
        if (isGazingUpon)
        {
            Debug.Log("gazed at instructor"); 
        }
        
    }

    public void GazingUpon()
    {
        isGazingUpon = true; 
    }
    public void NotGazingUpon()
    {
        isGazingUpon = false; 
    }
}
