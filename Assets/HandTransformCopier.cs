using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; 

public class HandTransformCopier : MonoBehaviour
{
    public string leftHandTransformFile; 
    // Start is called before the first frame update
    void Start()
    {
        leftHandTransformFile = "leftHandTransformFile.txt";
        CopyTransforms(this.gameObject.transform); 
    }


    void CopyTransforms(Transform sourceTransform)
    {

        string s = sourceTransform.name.ToString() + " " + sourceTransform.rotation.eulerAngles.ToString();
        using(StreamWriter w = File.AppendText(leftHandTransformFile))
        {
            w.WriteLine(s);
        }
        // Copy the positions, rotations, and scales of all child transforms recursively
        foreach (Transform sourceChild in sourceTransform)
        {
            Transform targetChild = sourceTransform.Find(sourceChild.name);
            if (targetChild)
            {
                CopyTransforms(sourceChild);
            }
        }
    }
    //flip yz signs
}
