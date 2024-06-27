using Photon.Pun;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 origin; // 弾を発射した時刻の座標
    private Vector3 velocity;
    private int timestamp; // 

    // 弾のIDを返すプロパティ
    public int Id { get; private set; }
    // 弾を発射したプレイヤーのIDを返すプロパティ
    public int OwnerId { get; private set; }
    // 同じ弾かどうかをIDで判定するメソッド
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