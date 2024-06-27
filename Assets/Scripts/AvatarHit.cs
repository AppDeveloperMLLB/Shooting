using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarHit : MonoBehaviourPunCallbacks
{
    private void OnTriggerEnter(Collider other)
    {
        if (photonView.IsMine)
        {
            if (other.TryGetComponent<Bullet>(out var bullet))
            {
                if (bullet.OwnerId != PhotonNetwork.LocalPlayer.ActorNumber)
                {
                    photonView.RPC(nameof(HitBullet), RpcTarget.All, bullet.Id, bullet.OwnerId);
                }
            }
        }
    }

    [PunRPC]
    private void HitBullet(int id, int ownerId)
    {
        var bullets = FindObjectsOfType<Bullet>();
        foreach (var bullet in bullets)
        {
            if (bullet.Equals(id, ownerId))
            {
                if(bullet.OwnerId == PhotonNetwork.LocalPlayer.ActorNumber)
                {
                    PhotonNetwork.LocalPlayer.AddScore(10);
                }

                Destroy(bullet.gameObject);
                break;
            }
        }
    }
}
