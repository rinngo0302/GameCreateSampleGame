using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//

public class GoSample: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))//スペースキーが押されたら
        {
            SceneManager.LoadScene("SampleScene");//SampleSceneを読み込む
        }

    }
}
