using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap : MonoBehaviour
{
    [SerializeField] ParticleSystem tapEffect;// タップエフェクト
    [SerializeField] Camera Ecamera;// カメラの座標

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // マウスのワールド座標までパーティクルを移動し、パーティクルエフェクトを1つ生成する
            Vector3 pos = Ecamera.ScreenToWorldPoint(Input.mousePosition + Ecamera.transform.forward * 20);
            tapEffect.transform.position = pos;
            tapEffect.Emit(1);
        }
    }
}