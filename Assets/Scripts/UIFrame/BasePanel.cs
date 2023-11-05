using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePanel 
{
    public UIType uiType;

    //��Panel�ڳ��������Ӧ������
    public GameObject ActiveObj;

    public BasePanel(UIType uitype)
    {
        uiType = uitype;
    }

    public virtual void OnStart()
    {
        Debug.Log("��ʼʹ��");//����
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
