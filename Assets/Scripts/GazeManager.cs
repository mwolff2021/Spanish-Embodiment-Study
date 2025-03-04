using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class GazeManager : MonoBehaviour
{
    public Camera viewCamera;
    private GameObject lastGazedUpon;
    public string fileName;
    //private List<string> objectsSeen;

    Dictionary<string, int> dict;


    void Start()
    {
        dict = new Dictionary<string, int>();
    }

    void Update()
    {
        CheckGaze();
    }
    void OnApplicationQuit()
    {
        Debug.Log("quitting");
        StreamWriter writetext = new StreamWriter(fileName);
        /*for (int i = 0; i < objectsSeen.Count; i++)
        {
            writetext.WriteLine(objectsSeen[i]);
        }
        writetext.Close();
        */
        foreach (KeyValuePair<string, int> ele in dict)
        {
            writetext.WriteLine("key: {0}, Value: {1}", ele.Key, ele.Value);
        }
        writetext.Close(); 
    }

    private void CheckGaze()
    {
        if (lastGazedUpon)
        {
            lastGazedUpon.SendMessage("NotGazingUpon", SendMessageOptions.DontRequireReceiver);
        }

        Ray gazeRay = new Ray(viewCamera.transform.position, viewCamera.transform.rotation * Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(gazeRay, out hit, Mathf.Infinity))
        {
            hit.transform.SendMessage("GazingUpon", SendMessageOptions.DontRequireReceiver);
            lastGazedUpon = hit.transform.gameObject;
            if (dict.ContainsKey(lastGazedUpon.ToString())){
                //int value = dict[lastGazedUpon.ToString()];
                dict[lastGazedUpon.ToString()] += 1;
            }
            else
            {
                dict.Add(lastGazedUpon.ToString(), 1); 
            }
            
            //Debug.Log("gazed" + lastGazedUpon.ToString()); 
        }
    }
            
}
