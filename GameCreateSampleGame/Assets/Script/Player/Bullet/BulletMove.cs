using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _bulletMaker;

    const float FIELD_W = 7;
    const float FIELD_H = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, _speed, 0) * Time.deltaTime);

        if (!isInField())
        {
            Destroy(gameObject);
        }
    }

    private bool isInField()
    {
        float x = transform.position.x;
        float y = transform.position.y;

        if (x >= -FIELD_W && x <= FIELD_W && y >= -FIELD_H && y <= FIELD_H)
            return true;
        return false;
    }
}
