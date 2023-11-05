using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
//�����ṹ��ʵ������ֻ��һ��ʵ������
public class UIManager
{
    //�洢UI Panel��ջ�ṹ
    public Stack<BasePanel> stack_ui;

    //�洢Panel����
    public Dictionary<string, GameObject> dict_ui;

    //��ǰ�����¶�Ӧ��Canvas
    public GameObject CanvasObj;

    private static UIManager instance;

    //��ȡʵ��
    public static UIManager GetInstance()
    {
        //ʵ��Ϊ�ձ���
        if (instance == null)
        {
            Debug.LogError("UIManager ʵ�岻����")
            return instance;
        }
        else
        {
            return instance;
        }
    }

    public UIManager()
    {
        instance = this;
    }

    //��ȡ��ʵ��
    public GameObject GetSingleObject(UIType uiType)
    {
        if (dict_uiobejct.Contains(uiType.Name))
        {
            return dict_uiobejct[uiType.Name];
        }
        if (CanvasObj == null)
        {
            Debug.LogError("UIManagerδ�ɹ����Canvas��")
            return null;
        }
        GameObject gameObject=gameObject.Instantiate<gameObject>(Resourse.Load<GameObject)(uiType.Path),CanvasObj.transform);
        return gameObject;
    }

    //��ջ
    public void Push(BasePanel basePanel)
    {
        Debug.Log($"{basePanel.uiType.Name}��Push��stack");

        if (stack_ui.Count > 0)
        {
            stack_ui.Peek().OnDisable();
        }

        GameObject ui_object = GetSingleObject(basePanel.uiType);
        dict_uiobject.Add(basePanel.uiType.Name, ui_object);
        basePanel.ActiveObj = ui_object;

        if (stack_ui.Count == 0)
        {
            stack_ui.Push(basePanel);
        }
        else
        {
            if (stack_ui.Peek().uiType.Name != basePanel.uiType.Name)
            {
                stack_ui.Push(basePanel);
            }
        }

        basePanel.OnStart();
    }


}
 
 
 
 */
