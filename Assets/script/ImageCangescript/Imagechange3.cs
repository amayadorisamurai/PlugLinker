using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imagechange3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangeImage4");
    }

    IEnumerator ChangeImage4()
    {
        // オブジェクトの取得
        GameObject image_object = GameObject.Find("Image4");
        Image image_component = image_object.GetComponent<Image>();
        // リソースから、切り替える画像を取得
        Texture2D clear4 = Resources.Load("clear4") as Texture2D;

        //3秒停止
        yield return new WaitForSeconds(1.5f);

        //反映させる
        image_component.sprite = Sprite.Create(clear4, new Rect(0, 0, clear4.width, clear4.height), Vector2.zero);
    }
}
