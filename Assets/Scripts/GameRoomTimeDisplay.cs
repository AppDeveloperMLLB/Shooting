using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameRoomTimeDisplay : MonoBehaviour
{
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!PhotonNetwork.InRoom)
        {
            return;
        }

        if(!PhotonNetwork.CurrentRoom.TryGetStartTime(out int timestamp))
        {
            return;
        }

        float elapesdTime = Mathf.Max(0f, unchecked(PhotonNetwork.ServerTimestamp - timestamp) / 1000f);
        text.text = elapesdTime.ToString("f1");
    }
}
