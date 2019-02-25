using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KInkyu : MonoBehaviour  //緊急処理用
{
    GameObject director;

    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }

    //トリガーが反応したとき
    private void OnTriggerEnter(Collider other)
    {
        //相手のタグが球なら
        if (other.gameObject.tag == "TAMA")
        {
            //相手を消す
            Destroy(other.gameObject);

            //残り球数を１増やす
            director.GetComponent<GameDirector>().NokoriPlas(1);

            //球を再召喚する
            director.GetComponent<GameDirector>().Point(0);
        }
    }

    void Update()
    {
    }
}
