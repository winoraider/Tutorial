using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameObject player;
    private PlayerController pc;

    private void OnTriggerEnter(Collider other) {
        player = GameObject.Find("Player");
        pc = player.GetComponent<PlayerController>();
        pc.score = pc.score + 1;
        pc.SetCountText();
        pc.point = pc.point + 1;

        Destroy(gameObject);//�A�^�b�`����Ă��鎩�����g������
        Destroy(other.gameObject);//�Ԃ���������iother�j������
    }

}
