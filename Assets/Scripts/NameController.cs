using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameController : MonoBehaviour
{
    public GameObject avatar;
    private float RandNum;
    TMPro.TextMeshProUGUI text;


    void Start()
    {

        //NameLabel = gameObject as GameObject;
        //text = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
    }


    private float FastFontSize = 30;//初期フォントサイズ
    private float FontScaleRate = 0.02f; //フォントサイズが変わる割合

    void Update()
    {

        ////座標を名前ラベルに
        //NameLabel.GetComponent<UILabel>().text =
        //        "X:" + transform.position.x.ToString("F2") +
        //        ", Z:" + transform.position.z.ToString("F2");



        ////フォントサイズ変更
        //GameObject Player = GameObject.FindGameObjectWithTag("Master").GetComponent<GameStartScript>().Player;
        //float SetFontSize = FastFontSize;
        //if (Player)
        //{

        //    //メインのプレイヤー(操作キャラ)との距離を元にフォントサイズを決定
        //    float Dis = Vector3.Distance(Player.transform.position, transform.position);

        //    SetFontSize /= (1.0f + Dis * FontScaleRate);

        //    //離れ過ぎたら文字を消す
        //    if (SetFontSize < FastFontSize * 0.5f)
        //    {
        //        SetFontSize = 0;
        //    }


        //    //カメラが向いてる方向にいない時はラベルを消す
        //    //これをしないと逆方向を向いて離れるとラベルが表示されてしまう


        //    //ターゲットとメインキャラの距離
        //    Vector3 TargetDirection = transform.position - Player.transform.position;
        //    //カメラの向きとターゲットキャラの方向の角度
        //    float Angle = Vector3.Angle(Camera.mainCamera.transform.forward, TargetDirection);


        //    //カメラの向いている方向にいない、かつ、ある程度離れている場合は名前ラベルを非表示
        //    if (Angle > 90)
        //    {

        //        //ある程度近い場合は逆方向でもラベルを表示する
        //        if (
        //                Mathf.Abs(transform.position.z - Player.transform.position.z) > 5.0f ||
        //                Mathf.Abs(transform.position.x - Player.transform.position.x) > 5.0f)
        //        {
        //            SetFontSize = 0;
        //        }
        //    }

        //    NameLabel.GetComponent<UILabel>().fontSize = (int)SetFontSize;
        //}



        ////スクリーン座標をもとに座標を設定 文字の大きさが小さい(距離が離れている)ほど上に表示
        //Vector3 screenPos = Camera.mainCamera.WorldToScreenPoint(transform.position);


        //NameLabel.transform.localPosition = new Vector3(
        //        screenPos.x - Screen.width * 0.5f,
        //        screenPos.y - Screen.height * 0.5f + Screen.height * (0.25f - (FastFontSize - SetFontSize) * 0.015f),
        //        1
        //);
    }

}
