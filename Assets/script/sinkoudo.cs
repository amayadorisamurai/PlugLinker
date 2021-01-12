using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sinkoudo : MonoBehaviour
{
    Slider _slider;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    float _hp = 0;
    void Update()
    {
        _hp += 0.01f;
        if (_hp > 1)
        { 
            _hp = 0;
        }

        _slider.value = _hp;
    }
}
