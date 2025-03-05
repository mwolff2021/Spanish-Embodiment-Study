using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPositioner : MonoBehaviour
{
    //public GameObject baseAvatar, currentAvatar; 
    public GameObject lHandBase, rHandBase, lHandAv, rHandAv; 
    // Start is called before the first frame update
    void Start()
    {
        //baseAvatar = GameObject.Find("Avatar");
        //currentAvatar = this.gameObject;
        //lHandBase =  baseAvatar.transform.Find("CC_Base_Bone_Root/CC_Base_Hip/CC_Base_Waist/CC_Base_Spine01/CC_Base_Spine02/CC_Base_L_Clavicle/CC_Base_L_Upperarm/CC_Base_L_Forearm/CC_Base_L_Hand");
        //lHandBase = lHand.transform; 
        //lHandAv =  currentAvatar.transform.Find("CC_Base_Bone_Root/CC_Base_Hip/_Base_Waist/CC_Base_Spine01/CC_Base_Spine02/CC_Base_L_Clavicle/CC_Base_L_Upperarm/CC_Base_L_Forearm/CC_Base_L_Hand");
        //rHandBase = baseAvatar.transform.Find("CC_Base_Bone_Root/CC_Base_Hip/CC_Base_Waist/CC_Base_Spine01/CC_Base_Spine02/CC_Base_R_Clavicle/CC_Base_R_Upperarm/CC_Base_R_Forearm/CC_Base_R_Hand");
        //rHandAv = currentAvatar.transform.Find("CC_Base_Bone_Root/CC_Base_Hip/Base_Waist/CC_Base_Spine01/CC_Base_Spine02/CC_Base_R_Clavicle/CC_Base_R_Upperarm/CC_Base_R_Forearm/CC_Base_R_Hand");
        CopyTransformTree(lHandBase.transform, lHandAv.transform);
        CopyTransformTree(rHandBase.transform, rHandAv.transform); 
    }
    public static void CopyTransformTree(Transform sourceRoot, Transform destRoot)
    {
        // Read local pose in one operation.
        sourceRoot.GetLocalPositionAndRotation(out var localPos, out var localRot);
        // Clone local pose to destination transform in one operation.
        destRoot.SetLocalPositionAndRotation(localPos, localRot);

        // Clone scale (skip if your bones don't use scale).
        destRoot.localScale = sourceRoot.localScale;

        // Iterate over as many children as both roots have.
        int limit = Mathf.Min(sourceRoot.childCount, destRoot.childCount);
        for (int i = 0; i < limit; i++) // Recurse on each child sub-tree.
            CopyTransformTree(sourceRoot.GetChild(i), destRoot.GetChild(i));
    }

   /* void LateUpdate()
    {
        CopyTransformTree(sourceRootBone, destRootBone);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
   */
}
