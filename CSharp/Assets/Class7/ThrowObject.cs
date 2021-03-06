﻿using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    [Header("傷害值"), Range(10, 500)]
    public float damage;
    [Header("爆炸效果")]
    public GameObject explosion;


    private void Explosion()
    {

        //生成爆炸效果
        GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);        //刪除怪物
        Destroy(exp, 2.5f);         //2.5f後刪除爆炸效果
    }



    //如果 碰觸.物件.名字 == "房子" ，呼叫爆炸()
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "房子")
        {
            collision.gameObject.GetComponent<House>().Damge(damage);
            Explosion();
        }
    }
}
