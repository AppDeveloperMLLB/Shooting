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


    private float FastFontSize = 30;//�����t�H���g�T�C�Y
    private float FontScaleRate = 0.02f; //�t�H���g�T�C�Y���ς�銄��

    void Update()
    {

        ////���W�𖼑O���x����
        //NameLabel.GetComponent<UILabel>().text =
        //        "X:" + transform.position.x.ToString("F2") +
        //        ", Z:" + transform.position.z.ToString("F2");



        ////�t�H���g�T�C�Y�ύX
        //GameObject Player = GameObject.FindGameObjectWithTag("Master").GetComponent<GameStartScript>().Player;
        //float SetFontSize = FastFontSize;
        //if (Player)
        //{

        //    //���C���̃v���C���[(����L����)�Ƃ̋��������Ƀt�H���g�T�C�Y������
        //    float Dis = Vector3.Distance(Player.transform.position, transform.position);

        //    SetFontSize /= (1.0f + Dis * FontScaleRate);

        //    //����߂����當��������
        //    if (SetFontSize < FastFontSize * 0.5f)
        //    {
        //        SetFontSize = 0;
        //    }


        //    //�J�����������Ă�����ɂ��Ȃ����̓��x��������
        //    //��������Ȃ��Ƌt�����������ė����ƃ��x�����\������Ă��܂�


        //    //�^�[�Q�b�g�ƃ��C���L�����̋���
        //    Vector3 TargetDirection = transform.position - Player.transform.position;
        //    //�J�����̌����ƃ^�[�Q�b�g�L�����̕����̊p�x
        //    float Angle = Vector3.Angle(Camera.mainCamera.transform.forward, TargetDirection);


        //    //�J�����̌����Ă�������ɂ��Ȃ��A���A������x����Ă���ꍇ�͖��O���x�����\��
        //    if (Angle > 90)
        //    {

        //        //������x�߂��ꍇ�͋t�����ł����x����\������
        //        if (
        //                Mathf.Abs(transform.position.z - Player.transform.position.z) > 5.0f ||
        //                Mathf.Abs(transform.position.x - Player.transform.position.x) > 5.0f)
        //        {
        //            SetFontSize = 0;
        //        }
        //    }

        //    NameLabel.GetComponent<UILabel>().fontSize = (int)SetFontSize;
        //}



        ////�X�N���[�����W�����Ƃɍ��W��ݒ� �����̑傫����������(����������Ă���)�قǏ�ɕ\��
        //Vector3 screenPos = Camera.mainCamera.WorldToScreenPoint(transform.position);


        //NameLabel.transform.localPosition = new Vector3(
        //        screenPos.x - Screen.width * 0.5f,
        //        screenPos.y - Screen.height * 0.5f + Screen.height * (0.25f - (FastFontSize - SetFontSize) * 0.015f),
        //        1
        //);
    }

}
