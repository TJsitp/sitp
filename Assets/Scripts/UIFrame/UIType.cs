using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIType
{
    private string path;
    private string name;

    public string Path { get => path; }
    public string Name { get => name; }


    //���UI��Ϣ
    //ui_path����Ӧpannel·��
    //ui_name����Ӧpannel����
    public UIType(string ui_path,string ui_name)
    {
        path = ui_path;
        name = ui_path;
    }
}
