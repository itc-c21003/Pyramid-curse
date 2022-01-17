using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap : MonoBehaviour
{
    [SerializeField] ParticleSystem tapEffect;// �^�b�v�G�t�F�N�g
    [SerializeField] Camera Ecamera;// �J�����̍��W

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // �}�E�X�̃��[���h���W�܂Ńp�[�e�B�N�����ړ����A�p�[�e�B�N���G�t�F�N�g��1��������
            Vector3 pos = Ecamera.ScreenToWorldPoint(Input.mousePosition + Ecamera.transform.forward * 20);
            tapEffect.transform.position = pos;
            tapEffect.Emit(1);
        }
    }
}