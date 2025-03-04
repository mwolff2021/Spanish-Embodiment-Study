using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems; 
using UnityEngine;

public class LightClick : MonoBehaviour, IPointerClickHandler
{
   public void OnPointerClick(PointerEventData pointerEventData) { 
        Debug.Log(pointerEventData.pointerCurrentRaycast.worldPosition); 
    }
}
