using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    [SerializeField, Header("PlayerSpeed"), Range(1f, 10f)]
    private float PlayerMoveSpeed = 3;
    private float MaxPlayerSpeed = 10;
    [SerializeField]
    player playerSc;
    [SerializeField, Header("コードマテリアル")]
    Material codemat;
    //コードの曲がり点記録用
    [SerializeField,Range(400,800)]
    int MaxCodeCount = 500;

    [SerializeField,Header("コードの長さ")]
    int CodeLength = 100;
    public void SetData()
    {
        playerSc.GSSpeed = PlayerMoveSpeed;
        playerSc.GSMaxSpeed = MaxPlayerSpeed;
        var line = playerSc.transform.GetChild(0).GetComponent<CodeLine>();
        line.GSmat = codemat;
        line.GSMaxCount = MaxCodeCount;
        line.GSCodelength = CodeLength;
    }
}
