using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIType
{
    private string path;
    private string name;

    public string Path { get => path; }
    public string Name { get => name; }


    //获得UI信息
    //ui_path：对应pannel路径
    //ui_name：对应pannel名称
    public UIType(string ui_path,string ui_name)
    {
        path = ui_path;
        name = ui_path;
    }
}
