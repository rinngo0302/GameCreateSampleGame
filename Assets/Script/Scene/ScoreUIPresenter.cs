using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUIPresenter : MonoBehaviour
{
    private GameObject scoreCounterObject;
    private ScoreCounter scoreCounterScript;
    private Text myText;

    private int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreCounterObject = GameObject.Find("ScoreCounter");//ヒエラルキー上のscorecounterという名前のオブジェクトを探す
        scoreCounterScript = scoreCounterObject.GetComponent<ScoreCounter>();//Scorecounterスクリプトを取得する
        myText = GetComponent<Text>();//スコアを取得
        score = scoreCounterScript.GetScore();//
        myText.text = score.ToString();//テキストを書き換え
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
