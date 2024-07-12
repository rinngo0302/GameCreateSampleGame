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
        scoreCounterObject = GameObject.Find("ScoreCounter");//�q�G�����L�[���scorecounter�Ƃ������O�̃I�u�W�F�N�g��T��
        scoreCounterScript = scoreCounterObject.GetComponent<ScoreCounter>();//Scorecounter�X�N���v�g���擾����
        myText = GetComponent<Text>();//�X�R�A���擾
        score = scoreCounterScript.GetScore();//
        myText.text = score.ToString();//�e�L�X�g����������
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
