using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_LookControl : MonoBehaviour
{

    // 鼠标灵敏度
    public float _mouseSensitivity = 200.0f;
    float _kcameraX = 0.0f;
    // 视角上下移动需要设定最大最小角度
    const float _kcameraXMax = 60f;
    const float _kcameraXMin = -60f;

    // 玩家
    public Transform _playerT = null;







    // Start is called before the first frame update
    void Start()
    {
        // 鼠标锁定
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible= false;
    }

    // Update is called once per frame
    void Update()
    {
        // 获取鼠标偏移
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * _mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * _mouseSensitivity;

        // 视角上下移动
        _kcameraX -= mouseY;
        // 在最大值最小值之间取值
        _kcameraX = Mathf.Clamp(_kcameraX, _kcameraXMin, _kcameraXMax);
        // 摄像机旋转
        transform.localRotation = Quaternion.Euler(_kcameraX, 0, 0);


        // 视角的左右移动，一般是360度，不需要额外的存储变量，摄像机是人物的子物体，直接转人即可
        if (_playerT != null)
        {
            _playerT.Rotate(_playerT.up, mouseX);
        }

    }
}
