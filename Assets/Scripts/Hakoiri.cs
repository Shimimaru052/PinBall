using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hakoiri : MonoBehaviour
{
    GameObject director;
    GameObject JP;

        //タグ取得用
    string Tag;

        //ポイント
    int Po;　

    void Start()
    {
        this.director = GameObject.Find("GameDirector");
        this.JP = GameObject.Find("TensuBakoJP");

        //アセットされたオブジェクトのタグを取得
        Tag = this.gameObject.tag;

        //取得したタグをint型に変換
        Po = int.Parse(Tag);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Tag == "100")       //JPの時
        {
        //残り球数を10増やす
            director.GetComponent<GameDirector>().NokoriPlas(10);

        //もしジャックポットフラグが真なら
            if (director.GetComponent<GameDirector>().JPC == true)
            {
        //ジャックポット箱を閉じる
                JP.transform.Translate(0, -0.95f, 0);
            }

        //ジャックポットフラグを偽にする
            director.GetComponent<GameDirector>().JPC = false;

        //SE再生
            GetComponent<AudioSource>().Play();

        //10個エフェクト用の球を召喚
            for(int i=0;i < 10; i++)
            {
                director.GetComponent<GameDirector>().Efect();
            }
        }
        else if(Tag == "20")    //JPCの時
        {
        //SE再生
            GetComponent<AudioSource>().Play();

        //もしジャックポットフラグが偽なら
            if (director.GetComponent<GameDirector>().JPC == false)
            {
        //ジャックポット箱を開く
                JP.transform.Translate(0, 0.95f, 0);
            }

        //ジャックポットフラグを真にする
            director.GetComponent<GameDirector>().JPC = true;
        }

        //
        director.GetComponent<GameDirector>().Point(Po);
        Destroy(other.gameObject);
    }

    void Update()
    {
    }
}
