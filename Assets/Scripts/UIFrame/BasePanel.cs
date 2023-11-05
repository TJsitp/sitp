using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePanel 
{
    public UIType uiType;

    //此Panel在场景里面对应的物体
    public GameObject ActiveObj;

    public BasePanel(UIType uitype)
    {
        uiType = uitype;
    }

    public virtual void OnStart()
    {
        Debug.Log("开始使用");//随便加
    }
    
    public virtual void OnEnable()
    {

    }

    public virtual void OnDisable()
    {

    }

    public virtual void OnDestroy()
    {

    }
}
