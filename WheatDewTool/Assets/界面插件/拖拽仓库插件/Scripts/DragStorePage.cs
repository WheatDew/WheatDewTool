using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragStorePage : MonoBehaviour
{
    public enum FloatElementType { Border,Borderless };

    public DragStorePageElement elementPrefab;
    public DragStorePageFloatElement floatElementPrefab;
    public Transform elementParent;
    public ScrollRect scrollRect;
    public FloatElementType floatElementType;

    public bool inBorder=false;

    private void Start()
    {
        //≤‚ ‘
        Test();
    }

    private void Update()
    {
        Debug.Log(inBorder);
        if (Input.GetMouseButtonUp(0))
        {
            scrollRect.movementType = ScrollRect.MovementType.Elastic;
        }
    }

    public void Test()
    {
        for(int i = 0; i < 1; i++)
        {
            var obj = Instantiate(elementPrefab,elementParent);
            obj.dragStorePage = this;
        }
    }
}
