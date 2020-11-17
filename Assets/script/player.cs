using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Vector2 Speed = new Vector2(0.05f, 0.05f);

    // Update is called once per frame
    private void Update(){
        //移動
        Move();
    }

    //移動関数
    void Move(){

        // 現在位置をPositionに代入
        Vector2 Position = transform.position;

        // 左キーを押し続けていたら
        if (Input.GetKey(KeyCode.LeftArrow)){
            // 代入したPositionに対して加算減算を行う
            Position.x -= Speed.x;
        }
        if (Input.GetKey(KeyCode.RightArrow)){ 
            Position.x += Speed.x;
        }
        if (Input.GetKey(KeyCode.UpArrow)){ 
            Position.y += Speed.y;
        }
        if (Input.GetKey(KeyCode.DownArrow)){ 
            Position.y -= Speed.y;
        }
        // 現在の位置にPositionを代入する
        transform.position = Position;
    }
}
