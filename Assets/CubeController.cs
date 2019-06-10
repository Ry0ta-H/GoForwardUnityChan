using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    //キューブの移動速度
    private float speed = -0.2f;

    //消滅位置
    private float deadLine = -10;

    public AudioSource Sound;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //障害物に衝突した場合
        if (other.gameObject.tag == "Ground"|| other.gameObject.tag == "Block tag")
        {
            Debug.Log("Hello world");
            Sound = GetComponent<AudioSource>() ;
            Sound.Play();
        }
    }
}
