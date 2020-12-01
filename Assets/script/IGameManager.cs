using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGameManager : MonoBehaviour
{
    [SerializeField]
    player Psc;
    [SerializeField]
    CodeLine codeline;
    [SerializeField]
    GameData Gdata;
    void Awake()
    {
        Gdata = transform.GetComponent<GameData>();
        //データ適応
        Gdata.SetData();
        //プレイヤー行動許可
        Psc.GSPlayerMove = true;
    }
}
