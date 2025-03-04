using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHead : MonoBehaviour
{
    Camera c; 
    // Start is called before the first frame update
    void Start()
    {
        c = (Camera)GameObject.FindObjectOfType(typeof(Camera));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = c.transform.rotation;
        //this.transform.position = c.transform.position; 
    }
}
