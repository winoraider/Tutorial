using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound;//上方向の制限
    [SerializeField] private float lowerBound;//下方向の制限
    void Update()
    {
        if(topBound < transform.position.z) {
            Destroy(gameObject);
            //gameObjectというのは自分で宣言していなくても使える
            //特殊な用語です。「このスクリプトがアタッチされている自分自身」
            //を指します。したがって、自分を消すという意味になります
        }else if(transform.position.z < lowerBound) {
            Destroy(gameObject);
            //【余談】実はDestroyは重い処理で、実際にはオブジェクトを消さず、
            //一時的に非表示にして使いまわすのがゲームは普通です。
            //これをオブジェクトプーリング（object pooling）といいます。
            //ただ、上級テクニックのでここでは普通にDestroyします。
        }
    }
}
