using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    GameObject pointText;
    GameObject nokoriText;

        //ポイント、スコア
    public static int point = 0;

        //残り球数
    int nokori = 9;

        //エフェクト用の球
    public GameObject ETama;

        //ゲーム用の球
    public GameObject Tama;

        //ジャックポットフラグ
    public bool JPC= false;

	void Start () {
        this.pointText = GameObject.Find("Point");
        this.nokoriText = GameObject.Find("Nokori");

        //ポイントリセット
        point = 0;
	}

    public void Point(int Px)
    {
        //ポイントを引数分増やす
        point += Px;

        //残り球数が0かどうか
        if(this.nokori > 0)
        {
         //残り球数を減らす
            nokori -= 1;

         //球を召喚する
            Instantiate(Tama) ;

        }
        else
        {
         //残り球数が0の時はリザルト画面に移行
            SceneManager.LoadScene("ResultScene");
        }
    }

    public void Efect()
    {
        //エフェクト用の球を召喚
        Instantiate(ETama);
    }

    public void NokoriPlas(int NP)
    {
        //残り球数を増やす
        this.nokori += NP;
    }

	void Update () {
        //ポイント表示
        this.pointText.GetComponent<Text>().text =
            point.ToString() + "Point";

        //残り球数表示
        this.nokoriText.GetComponent<Text>().text =
            "残り" + this.nokori.ToString() + "球";
    }

    //ポイントをリザルトにわたす
    public static int GetP()
    {
        return point;
    }

}
