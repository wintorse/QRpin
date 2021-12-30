using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorsOrDeactivate : MonoBehaviour
{
    bool isBlue;
    // Start is called before the first frame update
    public void RunOnTouchEnded()
    {
        if (!isBlue)
        {
            Debug.Log("notBlue");
            //変更したい色
            Color setColor = new Color32(0, 132, 255, 255);

            //Aをコピー
            //GameObject targetObj = Instantiate(this.gameObject);

            //対象のシェーダー情報を取得
            Shader sh = this.gameObject.transform.GetChild(0).gameObject.GetComponent<MeshRenderer>().material.shader;

            //取得したシェーダーを元に新しいマテリアルを作成
            Material mat = new Material(sh);

            //作成したマテリアルの色を変更
            mat.color = setColor;

            //対象オブジェクトに割り当てる
            this.gameObject.transform.GetChild(0).gameObject.GetComponent<MeshRenderer>().material = mat;

            isBlue = true;
        }
        else
        {
            Debug.Log("yes");
            this.gameObject.SetActive(false);
        }
    }
}