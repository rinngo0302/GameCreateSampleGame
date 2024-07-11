using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private int score;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);//このように書くとシーンをまたいでも消えなくなる
    }
    public void ScoreUp()
    {
        score = score + 1;
    }
    public int GetScore()//int型の返り値を持つメゾット
    {
        return score;//スコアを返す
    }
}
