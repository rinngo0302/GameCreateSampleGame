using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private int score;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);//���̂悤�ɏ����ƃV�[�����܂����ł������Ȃ��Ȃ�
    }
    public void ScoreUp()
    {
        score = score + 1;
    }
    public int GetScore()//int�^�̕Ԃ�l�������]�b�g
    {
        return score;//�X�R�A��Ԃ�
    }
}
