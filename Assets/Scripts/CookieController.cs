using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieController : MonoBehaviour
{
    private GameObject player;
    private PlayerController pc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(0,1,0));
    }
    private void OnTriggerEnter(Collider other)
    {
        player = GameObject.Find("Player");
        pc = player.GetComponent<PlayerController>();
        pc.score = pc.score + 1;
        pc.SetCountText();

        Destroy(other.gameObject);
    }
}
