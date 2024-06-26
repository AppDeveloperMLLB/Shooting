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
            // ���N���b�N�ŃJ�[�\���̕����ɒe�𔭎˂���
            if (Input.GetMouseButtonDown(0))
            {
                var pos = Camera.main.ScreenToWorldPoint(gameObject.transform.position);
                var direction = pos - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x);

                // �e�𔭎˂��邽�тɒe��ID��1�����₵�Ă���
                photonView.RPC(nameof(FireBullet), RpcTarget.All, nextBulletId++, angle);
            }
        }
    }

    // �e�𔭎˂��郁�\�b�h
    [PunRPC]
    private void FireBullet(int id, float angle)
    {
        var bullet = Instantiate(bulletPrefab);
        bullet.Init(id, photonView.OwnerActorNr, transform.position, angle);
    }
}