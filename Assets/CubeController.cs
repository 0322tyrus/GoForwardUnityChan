using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{


    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
     

        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="ground")
        {
           
            GetComponent<AudioSource>().Play();

        }
        else if (col.gameObject.tag == "Cube")
        {
            GetComponent<AudioSource>().Play();
        }
        
       
        
    }


}
