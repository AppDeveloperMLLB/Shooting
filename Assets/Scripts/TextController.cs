using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    private RectTransform myRectTfm;

    void Start()
    {
        myRectTfm = GetComponent<RectTransform>();
    }

    void Update()
    {
        // ���g�̌������J�����Ɍ�����
        myRectTfm.LookAt(Camera.main.transform);
    }
}