using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {

        Debug.Log("hiiii");

        if (collision.gameObject.name == target.name)
        {
            Debug.Log("hi");
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 10f * Time.deltaTime);
        }
    }
}
