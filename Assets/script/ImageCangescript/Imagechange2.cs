using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imagechange2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangeImage3");
    }

    IEnumerator ChangeImage3()
    {
        // オブジェクトの取得
        GameObject image_object = GameObject.Find("Image3");
        Image image_component = image_object.GetComponent<Image>();
        // リソースから、切り替える画像を取得
        Texture2D clear3 = Resources.Load("clear3") as Texture2D;

        //3秒停止
        yield return new WaitForSeconds(1.5f);

        //反映させる
        image_component.sprite = Sprite.Create(clear3, new Rect(0, 0, clear3.width, clear3.height), Vector2.zero);
    }
}
