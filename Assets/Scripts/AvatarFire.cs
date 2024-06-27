using Photon.Pun;
using UnityEngine;

public class AvatarFire : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Bullet bulletPrefab = default;

    private int nextBulletId = 0;

    private void Update()
    {
        if (photonView.IsMine)
        {
            // 左クリックでカーソルの方向に弾を発射する
            if (Input.GetMouseButtonDown(0))
            {
                var pos = Camera.main.ScreenToWorldPoint(gameObject.transform.position);
                var direction = pos - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x);

                // 弾を発射するたびに弾のIDを1ずつ増やしていく
                photonView.RPC(nameof(FireBullet), RpcTarget.All, nextBulletId++, angle);
            }
        }
    }

    // 弾を発射するメソッド
    [PunRPC]
    private void FireBullet(int id, PhotonMessageInfo info)
    {
        var bullet = Instantiate(bulletPrefab);
        // 弾を発射した時刻に50msのディレイをかける
        int timestamp = unchecked(info.SentServerTimestamp + 50);
        bullet.Init(id, photonView.OwnerActorNr, transform.position, timestamp);
    }
}