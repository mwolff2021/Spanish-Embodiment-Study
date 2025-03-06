using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructorPositioner : MonoBehaviour
{
    private GameObject instructor; 
    // Start is called before the first frame update
    void Start()
    {
        instructor = GameObject.Find("Instructor"); 
        instructor.transform.position = new Vector3(-3.51676083f, 0f, 0.443347573f);
        instructor.transform.eulerAngles = new Vector3(0.284326613f, 85.1706467f, 359.249664f); 
    }
}
