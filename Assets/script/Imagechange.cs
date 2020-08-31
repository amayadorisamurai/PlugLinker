using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imagechange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangeImage");
    }

    IEnumerator ChangeImage()
    {
        // オブジェクトの取得
        GameObject image_object = GameObject.Find("Image1");
        Image image_component = image_object.GetComponent<Image>();
        // リソースから、切り替える画像を取得
        Texture2D clear2 = Resources.Load("clear2") as Texture2D;

        //3秒停止
        yield return new WaitForSeconds(.2f);

        //反映させる
        image_component.sprite = Sprite.Create(clear2, new Rect(0, 0, clear2.width, clear2.height), Vector2.zero);
    }

}
