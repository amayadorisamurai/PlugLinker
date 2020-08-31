using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imagechange1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangeImage2");
    }

    IEnumerator ChangeImage2()
    {
        // オブジェクトの取得
        GameObject image_object = GameObject.Find("Image2");
        Image image_component = image_object.GetComponent<Image>();
        // リソースから、切り替える画像を取得
        Texture2D clear1 = Resources.Load("clear1") as Texture2D;

        //3秒停止
        yield return new WaitForSeconds(1f);

        //反映させる
        image_component.sprite = Sprite.Create(clear1, new Rect(0, 0, clear1.width, clear1.height), Vector2.zero);
    }
}
