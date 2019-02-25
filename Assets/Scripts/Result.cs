using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    public Text highScoreText;
    int highScore;
    string key = "HIGH SCORE";
    public Text RisText;
    int result;

    void Start()
    {
        result = GameDirector.GetP();
        highScore = PlayerPrefs.GetInt(key, 0);

        //スコア表示
        RisText.text = "SCORE : " + this.result.ToString();

        //ハイスコア上書き
        if (result > highScore)
        {
            highScore = result;
            PlayerPrefs.SetInt(key, highScore);
        }

        //ハイスコア表示
        highScoreText.text = "HIGH SCORE :" + highScore.ToString();
    }

    void Update()
    {
       
        //タイトルシーン移行
        if(Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("TitleScene");

        //ハイスコア情報の消去
        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
