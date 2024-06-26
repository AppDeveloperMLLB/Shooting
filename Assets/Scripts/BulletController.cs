using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 velocity;

    // �e��ID��Ԃ��v���p�e�B
    public int Id { get; private set; }
    // �e�𔭎˂����v���C���[��ID��Ԃ��v���p�e�B
    public int OwnerId { get; private set; }
    // �����e���ǂ�����ID�Ŕ��肷�郁�\�b�h
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