using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imagechange4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangeImage5");
    }

    IEnumerator ChangeImage5()
    {
        // オブジェクトの取得
        GameObject image_object = GameObject.Find("Image5");
        Image image_component = image_object.GetComponent<Image>();
        // リソースから、切り替える画像を取得
        Texture2D clear5 = Resources.Load("clear5") as Texture2D;

        //3秒停止
        yield return new WaitForSeconds(2f);

        //反映させる
        image_component.sprite = Sprite.Create(clear5, new Rect(0, 0, clear5.width, clear5.height), Vector2.zero);
    }
}
