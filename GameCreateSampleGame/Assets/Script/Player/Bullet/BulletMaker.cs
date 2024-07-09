using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMaker : MonoBehaviour
{
    [SerializeField] private float _interval;
    [SerializeField] private GameObject _bulletPrefab;

    float _time;

    // Start is called before the first frame update
    void Start()
    {
        _time = 0;
        gameObject.transform.parent = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void createBullet()
    {
        if (_time >= _interval)
        {
            Instantiate(_bulletPrefab, transform.position, _bulletPrefab.transform.rotation);
            _time = 0;
        }
        _time += Time.deltaTime;
    }
}
