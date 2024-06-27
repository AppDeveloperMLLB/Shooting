using Photon.Pun;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 origin; // �e�𔭎˂��������̍��W
    private Vector3 velocity;
    private int timestamp; // 

    // �e��ID��Ԃ��v���p�e�B
    public int Id { get; private set; }
    // �e�𔭎˂����v���C���[��ID��Ԃ��v���p�e�B
    public int OwnerId { get; private set; }
    // �����e���ǂ�����ID�Ŕ��肷�郁�\�b�h
    public bool Equals(int id, int ownerId) => id == Id && ownerId == OwnerId;

    public void Init(int id, int ownerId, Vector3 origin, int timestamp)
    {
        Id = id;
        OwnerId = ownerId;
        this.origin = origin;
        transform.position = origin;
        this.timestamp = timestamp;
        velocity = 9f * new Vector3(0, 0, 1);

        Update();
    }

    private void Start()
    {
        Invoke("Destroy", 5.0f);
    }

    private void Update()
    {
        float elapsedTime = Mathf.Max(0f, unchecked(PhotonNetwork.ServerTimestamp - timestamp) / 1000f);
        //transform.Translate(velocity * Time.deltaTime);
        transform.position = origin + velocity * elapsedTime;
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}