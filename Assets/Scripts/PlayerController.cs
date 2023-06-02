using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    float elapsedTime;
    bool counter_flag = false;
    public Text scoreText;
    public int score;
    public int point;
    private float horizontalInput;
    [SerializeField] private float speed;
    [SerializeField] private float xRange;
    [SerializeField] private GameObject[] projectilePrefab;//�H�ו��v���n�u�i���Ƃŕ����j
    void Start()
    {
        score = 0;
        SetCountText();
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput 
                * Time.deltaTime * speed);
        if(transform.position.x < -xRange) {
            transform.position = new Vector3(   -xRange, 
                                                transform.position.y,
                                                transform.position.z);
        }
        if(xRange < transform.position.x ) {
            transform.position = new Vector3(   xRange,
                                                transform.position.y,
                                                transform.position.z);
        }
        //�X�y�[�X�L�[�������ꂽ��
        if(Input.GetKeyDown(KeyCode.Space)) {
            //�����ŐH�ו��𕡐�����i���̎g�����A�Ƃ��������\�b�h���o���āI�j
            Instantiate(    projectilePrefab[0], 
                            transform.position,
                            projectilePrefab[0].transform.rotation);
        }
        if(point >= 5)
        {
            //Deathblow = true;
            if (Input.GetKeyDown(KeyCode.X))
            {
                Instantiate(projectilePrefab[1],
                            transform.position,
                            projectilePrefab[1].transform.rotation);
                point = 0;
                counter_flag = true;
                //Deathblow = false;
            }
        }
        if(counter_flag == true)
        {
            elapsedTime += Time.deltaTime;
        }
        if(elapsedTime >= 10)
        {
            Destroy(gameObject);
            counter_flag = false;
            elapsedTime = 0;
        }
    }
    public void SetCountText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
