using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class NpcControl : MonoBehaviour
{
    public string ChatName;
    // Start is called before the first frame update

    //��ǰ�Ƿ���ԶԻ�
    private bool canChat = false;

    //���봥������Χ
    private  void OnTriggerEnter(Collider other)
    {
        canChat = true;
    }

    //�뿪��������Χ
    private void OnTriggerExit(Collider other)
    {
        canChat = false;
    }

    // Update is called once per frame
    private void Update()
    {
        /*
           //����S�Ի�
          if(Input.GetKey(KeyCode.S))
          {
              Say();
          }
         */
    }

    //���npc�����Ի�
    private void OnMouseDown()
    {
        Say();
    }

    //�Ի�
    void Say()
    {
        if (canChat)
        {
            //��ʼ�Ի�
            Flowchart flowChart = GameObject.Find("Flowchart").GetComponent<Flowchart>();//ȡ�ö�Ӧ�Ի����
            //�Ի��Ƿ����
            if (flowChart.HasBlock(ChatName))
            {
                //ִ�жԻ�
                flowChart.ExecuteBlock(ChatName);
            }
        }
    }
}
