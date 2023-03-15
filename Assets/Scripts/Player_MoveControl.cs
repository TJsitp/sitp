using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MoveControl : MonoBehaviour
{
    // 移动的速度
    public float _walkSpeed;
    // 重力
    public float _gravity;
    // 跳跃高度
    public float _jumpHeight;
    // 角色控制器
    CharacterController _player = null;







    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // 获取水平垂直轴的偏移
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 确定前进方向
        Vector3 moveDir = transform.right * h + transform.forward * v;
        // 重力模拟
        Vector3 downMove = -_player.transform.up * _gravity * Time.deltaTime;
        //// 跳跃
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    moveDir += transform.up * _jumpHeight;
        //}
        // 移动
        _player.Move(downMove + moveDir * _walkSpeed * Time.deltaTime);

    }
}
