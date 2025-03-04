using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBody : MonoBehaviour
{
    Camera cam;
    public float xadj, yadj, zadj;
    // Start is called before the first frame update
    void Start()
    {
        cam = (Camera)GameObject.FindObjectOfType(typeof(Camera));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = cam.transform.position - new Vector3(xadj, yadj, zadj);
        //this.transform.position = c.transform.position; 
    }
}
