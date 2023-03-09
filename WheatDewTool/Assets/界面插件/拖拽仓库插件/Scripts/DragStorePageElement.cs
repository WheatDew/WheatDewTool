using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class DragStorePageElement : MonoBehaviour, IPointerDownHandler,IPointerExitHandler
{
    [HideInInspector] public DragStorePage dragStorePage;

    public void OnPointerDown(PointerEventData eventData)
    {
        if(eventData.pointerId == -1)
        {
            dragStorePage.scrollRect.movementType = UnityEngine.UI.ScrollRect.MovementType.Clamped;
            Instantiate(dragStorePage.floatElementPrefab,FindObjectOfType<Canvas>().transform);
            Debug.Log("×ó¼ü´¥·¢");
        }
        Debug.Log("µã»÷´¥·¢");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
}
