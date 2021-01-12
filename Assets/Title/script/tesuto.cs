using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //uGUIを使うとき必ず必要

public class tesuto : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = GameObject.Find("Canvas/StartButton").GetComponent<Button>();
        //ボタンが選択された状態になる
        button.Select();
    }
}

