using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;/*�л�����������ӵ�ǰ׺*/

public class SceneChange : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    public void ChangeScene(string scene)/*����һ���л�����*/
    {
        SceneManager.LoadScene(scene);/*˫�������������㴴���ĳ�������*/
    }

}