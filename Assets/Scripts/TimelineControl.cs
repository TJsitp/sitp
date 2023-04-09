using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;


public class TimelineControl : MonoBehaviour
{
    //动画控制器组件
    public PlayableDirector Animationcontroller;

    //Timeline数组，保存Timeline里的5个动画片段
    public TimelineAsset[] timelines;

    //保存Timeline对应变量名称
    public string[] timelinenames;

    //对话系统
    public Flowchart flowchart;

    // Update is called once per frame
    void Update()
    {
        //遍历timeline数组
        for(int i = 0; i < timelines.Length; i++)
        {
            //如果是，则播放该timeline
            if (flowchart.GetBooleanVariable(timelinenames[i]))
                Animationcontroller.Play(timelines[i]);
            //播放结束后将对应变量值改为false
            flowchart.SetBooleanVariable(timelinenames[i], false);
        }
    }
}
