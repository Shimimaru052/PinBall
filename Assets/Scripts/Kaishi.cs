using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kaishi : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //スペースキーでゲームシーンに移行
        if(Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("GameScene");
    }
}
