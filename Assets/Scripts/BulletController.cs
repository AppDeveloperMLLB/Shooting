using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 velocity;

    // 弾のIDを返すプロパティ
    public int Id { get; private set; }
    // 弾を発射したプレイヤーのIDを返すプロパティ
    public int OwnerId { get; private set; }
    // 同じ弾かどうかをIDで判定するメソッド
    public bool Equals(int id, int ownerId) => id == Id && ownerId == OwnerId;

    public void Init(int id, int ownerId, Vector3 origin, float angle)
    {
        Id = id;
        OwnerId = ownerId;
        transform.position = origin;
        velocity = 9f * new Vector3(0, 0, 1);
    }

    private void Start()
    {
        Invoke("Destroy", 5.0f);
    }

    private void Update()
    {
        transform.Translate(velocity * Time.deltaTime);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}