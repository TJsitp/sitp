using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;


public class TimelineControl : MonoBehaviour
{
    //�������������
    public PlayableDirector Animationcontroller;

    //Timeline���飬����Timeline���5������Ƭ��
    public TimelineAsset[] timelines;

    //����Timeline��Ӧ��������
    public string[] timelinenames;

    //�Ի�ϵͳ
    public Flowchart flowchart;

    // Update is called once per frame
    void Update()
    {
        //����timeline����
        for(int i = 0; i < timelines.Length; i++)
        {
            //����ǣ��򲥷Ÿ�timeline
            if (flowchart.GetBooleanVariable(timelinenames[i]))
                Animationcontroller.Play(timelines[i]);
            //���Ž����󽫶�Ӧ����ֵ��Ϊfalse
            flowchart.SetBooleanVariable(timelinenames[i], false);
        }
    }
}
