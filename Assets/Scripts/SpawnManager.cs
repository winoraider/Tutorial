using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefabs;
    [SerializeField] float spawnRangeX;
    [SerializeField] float spawnPosZ;
    [SerializeField] float spawnInterval;//生成間隔
    float elapsedTime;//経過時間
    void Update()
    {
        elapsedTime += Time.deltaTime;//毎Fの時間を加えていく...

        //カウントされている時間が一定を超えたら...
        if(elapsedTime > spawnInterval) {
            SpawnRandomAnimal();
            elapsedTime = 0.0f;//経過時間リセットしないと大量生成される
        }
    }
    //Updateの下に書いて！でもクラス内に書いて！！
    void SpawnRandomAnimal() {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
                                        0,
                                        spawnPosZ);
        Instantiate(animalPrefabs[animalIndex],
                    spawnPos,
                    animalPrefabs[animalIndex].transform.rotation);
    }
}//ここがクラスの終わり
//ここから書いちゃう人がいる...ダメ
