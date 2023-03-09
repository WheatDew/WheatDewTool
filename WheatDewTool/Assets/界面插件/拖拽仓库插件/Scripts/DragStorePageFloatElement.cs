using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragStorePageFloatElement : MonoBehaviour
{
    [SerializeField] private RectTransform rectTransform;
    [HideInInspector] public DragStorePage dragStorePage;

    private void Update()
    {
        rectTransform.position = Input.mousePosition;

        if (dragStorePage.floatElementType==DragStorePage.FloatElementType.Border
            &&!dragStorePage.inBorder)
        {
            ResponseEvent();
        }

        if (Input.GetMouseButtonUp(0))
        {
            ResponseEvent();
        }
    }

    public void ResponseEvent()
    {
        Debug.Log("触发响应事件");
        Destroy(gameObject);
    }
}
