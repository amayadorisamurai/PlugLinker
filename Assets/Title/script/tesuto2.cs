using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //uGUIを使うとき必ず必要

public class tesuto2 : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = GameObject.Find("Canvas/Button").GetComponent<Button>();
        //ボタンが選択された状態になる
        button.Select();
    }
}