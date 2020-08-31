using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageChange5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangeImage6");
    }

    IEnumerator ChangeImage6()
    {
        // オブジェクトの取得
        GameObject image_object = GameObject.Find("Image6");
        Image image_component = image_object.GetComponent<Image>();
        // リソースから、切り替える画像を取得
        Texture2D clear6 = Resources.Load("GameClear Image") as Texture2D;

        //3秒停止
        yield return new WaitForSeconds(2f);

        //反映させる
        image_component.sprite = Sprite.Create(clear6, new Rect(0, 0, clear6.width, clear6.height), Vector2.zero);


        //3秒停止
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("GameClear");
    }
}
