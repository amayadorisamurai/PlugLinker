using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeLine : MonoBehaviour
{
    float _fLineSpeed;
    LineRenderer line;
    int Count = 0;
    int iMaxCount;
    int Distributor = 0;
    bool bCodeLong = false;
    int iMaxCodeLength;
    float fCodeLength = 0;
    player PSc;
    Material mat;
    public Material GSmat
    {
        set { mat = value; }
    }
    public int GSMaxCount
    {
        set { iMaxCount = value; }
    }
    public int GSCodelength
    {
        set { iMaxCodeLength = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        if (mat)
            line.material = mat;
        PSc = transform.parent.GetComponent<player>();
        _fLineSpeed = (int)(PSc.GSMaxSpeed - PSc.GSSpeed);
        //初期位置記録用
        DrawLine();
    }

    // Update is called once per frame
    void Update()
    {
        switch (PSc.GetPlayerState())
        {
            case 0:break;
            case 1:
                DrawLine();
                break;
            case 2:
            case 4:
                if (!PSc.GetMouseTargetPosbecouse())
                {
                    if (Distributor != 0)
                    {
                        Distributor--;
                    }
                    else
                    {
                        DrawLine();
                        Distributor = (int)_fLineSpeed;
                        bCodeLong = false;
                    }
                }
                else
                {
                    DrawLongLine();
                }
                break;
            case 3:
                DrawLine();
                break;
        }
    }
    //Line終点を追加
    void DrawLine()
    {
        AddCodeLength();
        Count++;
        line.positionCount = Count;
        line.SetPosition(Count - 1, transform.position);

        if (Count > iMaxCount) Count = 0;
    }
    //Line終点を変更、長線化
    void DrawLongLine()
    {
        bCodeLong = true;
        line.SetPosition(Count - 1, transform.position);
    }
    //2点間の長さ算出
    float CheckLineLength(int i)
    {
        if (2 + i <= Count)
            return Vector2.Distance(line.GetPosition(Count - 1 - i), line.GetPosition(Count - 2 - i));
        return 0;
    }
    //全ての長さを合算
    void AddCodeLength()
    {
        //変更しない部分を加算
        fCodeLength += CheckLineLength(1);
        float instantadd = fCodeLength + CheckLineLength(0);
        //コードの長さが規定以上のとき
        if(instantadd >= iMaxCodeLength)
        {
            //プレイヤー移動禁止
            PSc.GSPlayerMove = false;
            Debug.Log("規定の長さを超えた！");
        }
    }
}
