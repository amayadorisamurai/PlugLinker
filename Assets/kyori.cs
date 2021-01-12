using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kyori : MonoBehaviour
{
    int score;
    GameObject MetleText;

    public void AddScore()
    {
        this.score = 100;
    }

    void Start()
    {
        this.MetleText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos1 = new Vector2(10.0f, 24.0f);//ゴール地点を入れる（新しく変数を作って入れる）
        Vector2 pos2 = new Vector2(3.0f, 10.0f);//現在地を入れる（）
        Debug.Log(Vector2.Distance(pos1, pos2));
        Debug.Log((pos1 - pos2).magnitude);
        Debug.Log(Mathf.Sqrt(Mathf.Pow(pos1.x - pos2.x, 2) + Mathf.Pow(pos1.y - pos2.y, 2)));
    }
}
