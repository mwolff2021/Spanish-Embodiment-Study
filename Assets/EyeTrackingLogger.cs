using UnityEngine;
using UnityEngine.InputSystem;
public class EyeTrackingLogger: MonoBehaviour
{
    [SerializeField] InputActionReference EyeTracker;

    [SerializeField] InputActionAsset ActionAsset;

    void Update()
    {
        Debug.Log("Eye tracker pose");
        Debug.Log(EyeTracker.action.ReadValue<Pose>());
    }

     void Start()
    {
        if (ActionAsset != null)
        {
            ActionAsset.Enable();
        }
    }
}
