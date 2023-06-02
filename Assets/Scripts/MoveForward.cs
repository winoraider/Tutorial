using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {
        //Vector3.forwardは前方向（正確にはz方向=青色の軸）
        //それに、速さ×時間をした距離だけ移動させるようにしている
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
