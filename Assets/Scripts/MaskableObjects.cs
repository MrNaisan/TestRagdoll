using UnityEngine;
using System;

public class MaskableObjects : MonoBehaviour
{
    private Material mat;
    [NonSerialized]
    public bool isHide = false;

    private void Start() 
    {
        mat = GetComponent<MeshRenderer>().material;    
    }

    private void Update() 
    {
        if(isHide)    
            SetMask();
        else
            SetColor();
        isHide = false;
    }

    public void SetMask()
    {
        mat.color = new Vector4(mat.color.r, mat.color.g, mat.color.b, 0);
    }

    public void SetColor()
    {
        mat.color = new Vector4(mat.color.r, mat.color.g, mat.color.b, 1);
    }
}
