using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(), TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        var pos = new Vector3(Random.Range(-3f, 3f), 0, Random.Range(-3f, 3f));
        PhotonNetwork.Instantiate("Avatar", pos, Quaternion.identity);
        try
        {
            var nr = photonView.OwnerActorNr;
            Debug.Log(nr.ToString());
        } catch(System.Exception e)
        {
            Debug.Log(e);
        }

    }
}
