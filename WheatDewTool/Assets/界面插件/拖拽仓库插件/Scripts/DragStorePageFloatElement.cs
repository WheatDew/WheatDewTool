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

        if (dragStorePage)
        {

        }

        if (Input.GetMouseButtonUp(0))
        {
            Destroy(gameObject);
        }
    }
}
