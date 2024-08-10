using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float enemyspeed = -5;
    [SerializeField] private float enemylifetime;

    private GameObject scoreconterobject;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, enemyspeed) * Time.deltaTime);

        enemylifetime = enemylifetime - Time.deltaTime;

        if (enemylifetime < 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {


            Debug.Log("bullet");
            Destroy(this.gameObject);
        }
    }
}

