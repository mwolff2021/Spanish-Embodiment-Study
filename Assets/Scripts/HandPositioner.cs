using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPositioner : MonoBehaviour
{
    //public GameObject baseAvatar, currentAvatar; 
    private GameObject avatar;  
    // Start is called before the first frame update
    void Start()
    {
        avatar = GameObject.Find("Avatar"); 
        Debug.Log(avatar); 
        //Debug.Log(GetGameObjectPath(objevt)); 
        CopyTransformsToHand(); 
    }

    public static string GetGameObjectPath(GameObject obj)
    {
        string path = "/" + obj.name;
        while (obj.transform.parent != null)
        {
            obj = obj.transform.parent.gameObject;
            path = "/" + obj.name + path;
        }
        return path;
    }

    void CopyTransformsToHand()
    {

        string handPathL = "CC_Base_BoneRoot/CC_Base_Hip/CC_Base_Waist/CC_Base_Spine01/CC_Base_Spine02/CC_Base_L_Clavicle/CC_Base_L_Upperarm/CC_Base_L_Forearm/";
        /*Debug.Log(avatar);
        Debug.Log(avatar.gameObject);
        Debug.Log(avatar.gameObject.transform);
        Debug.Log(avatar.gameObject.transform.Find("CC_Base_BoneRoot"));
        Debug.Log(avatar.gameObject.transform.Find(handPathL + "CC_Base_L_Hand")); 
        Debug.Log(avatar.gameObject.transform.Find(handPathL + "CC_Base_L_Hand").transform.eulerAngles); //= new Vector3(3.06f, 174.77f, 121.07f);
        */
        avatar.gameObject.transform.Find(handPathL + "CC_Base_L_Hand").transform.eulerAngles = new Vector3(3.06f, 174.77f, 121.07f);
        avatar.gameObject.transform.Find(handPathL + "CC_Base_L_Hand/" + "CC_Base_L_Index1").gameObject.transform.eulerAngles = new Vector3(3.68f, 173.25f, 151.99f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/" + "CC_Base_L_Index1/" + "CC_Base_L_Index2").gameObject.transform.eulerAngles = new Vector3(5.14f, 173.23f, 220.98f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/" + "CC_Base_L_Index1/" + "CC_Base_L_Index2/" + "CC_Base_L_Index3").gameObject.transform.eulerAngles = new Vector3(6.25f, 174.44f, 281.10f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/" + "CC_Base_L_Mid1").gameObject.transform.eulerAngles = new Vector3(4.41f, 172.17f, 151.91f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/CC_Base_L_Mid1/CC_Base_L_Mid2").gameObject.transform.eulerAngles = new Vector3(5.08f, 172.27f, 211.92f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/CC_Base_L_Mid1/CC_Base_L_Mid2/CC_Base_L_Mid3").gameObject.transform.eulerAngles = new Vector3(6.36f, 173.29f, 272.01f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/CC_Base_L_Pinky1").gameObject.transform.eulerAngles = new Vector3(4.48f, 172.69f, 151.93f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/CC_Base_L_Pinky1/CC_Base_L_Pinky2").gameObject.transform.eulerAngles = new Vector3(5.01f, 172.07f, 211.88f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/CC_Base_L_Pinky1/CC_Base_L_Pinky2/CC_Base_L_Pinky3").gameObject.transform.eulerAngles = new Vector3(5.32f, 173.05f, 271.97f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/CC_Base_L_Ring1").gameObject.transform.eulerAngles = new Vector3(4.14f, 173.44f, 151.99f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/CC_Base_L_Ring1/CC_Base_L_Ring2").gameObject.transform.eulerAngles = new Vector3(4.02f, 173.49f, 211.99f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/CC_Base_L_Ring1/CC_Base_L_Ring2/CC_Base_L_Ring3").gameObject.transform.eulerAngles = new Vector3(4.03f, 173.76f, 272.01f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/CC_Base_L_Thumb1").gameObject.transform.eulerAngles = new Vector3(350.61f, 212.00f, 159.78f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/CC_Base_L_Thumb1/CC_Base_L_Thumb2").gameObject.transform.eulerAngles = new Vector3(8.54f, 207.77f, 134.44f);
        avatar.transform.Find(handPathL + "CC_Base_L_Hand/CC_Base_L_Thumb1/CC_Base_L_Thumb2/CC_Base_L_Thumb3").gameObject.transform.eulerAngles = new Vector3(42.28f, 150.92f, 107.27f);

        string handPathR = "CC_Base_BoneRoot/CC_Base_Hip/CC_Base_Waist/CC_Base_Spine01/CC_Base_Spine02/CC_Base_R_Clavicle/CC_Base_R_Upperarm/CC_Base_R_Forearm/";
        avatar.gameObject.transform.Find(handPathR + "CC_Base_R_Hand").transform.eulerAngles = new Vector3(3.06f, -174.77f, -121.07f);
        avatar.gameObject.transform.Find(handPathR + "CC_Base_R_Hand/" + "CC_Base_R_Index1").gameObject.transform.eulerAngles = new Vector3(3.68f, -173.25f, -151.99f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/" + "CC_Base_R_Index1/" + "CC_Base_R_Index2").gameObject.transform.eulerAngles = new Vector3(5.14f, -173.23f, -220.98f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/" + "CC_Base_R_Index1/" + "CC_Base_R_Index2/" + "CC_Base_R_Index3").gameObject.transform.eulerAngles = new Vector3(6.25f, -174.44f, -281.10f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/" + "CC_Base_R_Mid1").gameObject.transform.eulerAngles = new Vector3(4.41f, -172.17f, -151.91f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/CC_Base_R_Mid1/CC_Base_R_Mid2").gameObject.transform.eulerAngles = new Vector3(5.08f, -172.27f, -211.92f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/CC_Base_R_Mid1/CC_Base_R_Mid2/CC_Base_R_Mid3").gameObject.transform.eulerAngles = new Vector3(6.36f, -173.29f, -272.01f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/CC_Base_R_Pinky1").gameObject.transform.eulerAngles = new Vector3(4.48f, -172.69f, -151.93f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/CC_Base_R_Pinky1/CC_Base_R_Pinky2").gameObject.transform.eulerAngles = new Vector3(5.01f, -172.07f, -211.88f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/CC_Base_R_Pinky1/CC_Base_R_Pinky2/CC_Base_R_Pinky3").gameObject.transform.eulerAngles = new Vector3(5.32f, -173.05f, -271.97f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/CC_Base_R_Ring1").gameObject.transform.eulerAngles = new Vector3(4.14f, -173.44f, -151.99f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/CC_Base_R_Ring1/CC_Base_R_Ring2").gameObject.transform.eulerAngles = new Vector3(4.02f, -173.49f, -211.99f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/CC_Base_R_Ring1/CC_Base_R_Ring2/CC_Base_R_Ring3").gameObject.transform.eulerAngles = new Vector3(4.03f, -173.76f, -272.01f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/CC_Base_R_Thumb1").gameObject.transform.eulerAngles = new Vector3(350.61f, -212.00f, -159.78f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/CC_Base_R_Thumb1/CC_Base_R_Thumb2").gameObject.transform.eulerAngles = new Vector3(8.54f, -207.77f, -134.44f);
        avatar.transform.Find(handPathR + "CC_Base_R_Hand/CC_Base_R_Thumb1/CC_Base_R_Thumb2/CC_Base_R_Thumb3").gameObject.transform.eulerAngles = new Vector3(42.28f, -150.92f, -107.27f);

    }

}
