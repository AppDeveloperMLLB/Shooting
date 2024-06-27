using UnityEngine;
using TMPro;
using System.Text;
using Photon.Pun;
using System;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI text;

    private float elapsedTime;
    private StringBuilder sb;

    // Start is called before the first frame update
    void Start()
    {
        sb = new StringBuilder();
        elapsedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!PhotonNetwork.InRoom) { return; }
        elapsedTime += Time.deltaTime;
        if(elapsedTime > 0.1f)
        {
            elapsedTime = 0;
            UpdateLabel();
        }
    }

    void UpdateLabel()
    {
        var players = PhotonNetwork.PlayerList;
        Array.Sort(players, (p1, p2) =>
        {
            int diff = p2.GetScore() - p1.GetScore();
            if (diff != 0) return diff;
            return p1.ActorNumber - p2.ActorNumber;
        });

        sb.Clear();
        foreach(var player in players)
        {
            sb.AppendLine($"{player.NickName}({player.ActorNumber}) - {player.GetScore()}");
        }
        text.text = sb.ToString();
    }
}
