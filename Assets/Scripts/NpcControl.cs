using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class NpcControl : MonoBehaviour
{
    public string ChatName;
    // Start is called before the first frame update

    //当前是否可以对话
    private bool canChat = false;

    //进入触发器范围
    private  void OnTriggerEnter(Collider other)
    {
        canChat = true;
    }

    //离开触发器范围
    private void OnTriggerExit(Collider other)
    {
        canChat = false;
    }

    // Update is called once per frame
    private void Update()
    {
        /*
           //键盘S对话
          if(Input.GetKey(KeyCode.S))
          {
              Say();
          }
         */
    }

    //点击npc产生对话
    private void OnMouseDown()
    {
        Say();
    }

    //对话
    void Say()
    {
        if (canChat)
        {
            //开始对话
            Flowchart flowChart = GameObject.Find("Flowchart").GetComponent<Flowchart>();//取得对应对话组件
            //对话是否存在
            if (flowChart.HasBlock(ChatName))
            {
                //执行对话
                flowChart.ExecuteBlock(ChatName);
            }
        }
    }
}
