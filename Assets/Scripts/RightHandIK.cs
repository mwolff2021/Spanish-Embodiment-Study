using UnityEngine;

public class RightHandIK : MonoBehaviour
{
    public Transform rightVRController, leftVRController, headController;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnAnimatorIK(int layerIndex)
    {
        float reach = animator.GetFloat("RightHand");
        float lreach = animator.GetFloat("LeftHand");
        //float head = animator.GetFloat("Head"); 
        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, reach);
        animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, lreach);
        //animator.SetIKRotationWeight(AvatarIKGoal.RightHand, reach);
        //animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, lreach);
        //animator.SetIKRotationWeight(Avatar.)
        animator.SetIKPosition(AvatarIKGoal.RightHand, rightVRController.position);
        animator.SetIKPosition(AvatarIKGoal.LeftHand, leftVRController.position);
        //animator.SetIKRotation(AvatarIKGoal.RightHand, rightVRController.rotation);
        //animator.SetIKRotation(AvatarIKGoal.LeftHand, leftVRController.rotation);
        //animator.SetIKPosition(AvatarIKGoal.LeftHand, leftVRController.position);
        animator.SetLookAtWeight(1f);
        animator.SetLookAtPosition(headController.position + headController.forward * 10f);
        animator.SetBoneLocalRotation(HumanBodyBones.Jaw, Quaternion.Euler(0f, 0f, -90f));

    }

}