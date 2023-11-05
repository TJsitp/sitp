using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 
//单例结构：实例化后只有一个实例存在
public class UIManager
{
    //存储UI Panel的栈结构
    public Stack<BasePanel> stack_ui;

    //存储Panel名称
    public Dictionary<string, GameObject> dict_ui;

    //当前场景下对应的Canvas
    public GameObject CanvasObj;

    private static UIManager instance;

    //获取实例
    public static UIManager GetInstance()
    {
        //实例为空报错
        if (instance == null)
        {
            Debug.LogError("UIManager 实体不存在")
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

    //获取单实例
    public GameObject GetSingleObject(UIType uiType)
    {
        if (dict_uiobejct.Contains(uiType.Name))
        {
            return dict_uiobejct[uiType.Name];
        }
        if (CanvasObj == null)
        {
            Debug.LogError("UIManager未成功获得Canvas！")
            return null;
        }
        GameObject gameObject=gameObject.Instantiate<gameObject>(Resourse.Load<GameObject)(uiType.Path),CanvasObj.transform);
        return gameObject;
    }

    //进栈
    public void Push(BasePanel basePanel)
    {
        Debug.Log($"{basePanel.uiType.Name}被Push进stack");

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
