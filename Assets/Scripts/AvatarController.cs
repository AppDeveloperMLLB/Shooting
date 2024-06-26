using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarController : MonoBehaviourPunCallbacks, IPunObservable
{
    private const float MaxStamina = 6.0f;

    [SerializeField]
    private Slider slider = default;

    private float currentStamina = MaxStamina;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // ���g�����������I�u�W�F�N�g�����Ɉړ��������s��
        if (photonView.IsMine)
        {
            var input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            if(input.sqrMagnitude > 0f)
            {
                currentStamina = Mathf.Max(0f, currentStamina - Time.deltaTime);
                transform.Translate(6f * Time.deltaTime * input.normalized);
            }
        }

        slider.value = currentStamina / MaxStamina;
    }

    void IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            // ���g�̃A�o�^�[�̃X�^�~�i�𑗐M����
            stream.SendNext(currentStamina);
        }
        else
        {
            // ���v���C���[�̃A�o�^�[�̃X�^�~�i����M����
            currentStamina = (float)stream.ReceiveNext();
        }
    }
}
