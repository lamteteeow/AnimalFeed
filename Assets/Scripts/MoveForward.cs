using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    private float animalBound = 15.0f;
    private float foodBound = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
        if (transform.position.z < -animalBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z > foodBound)
        {
            Destroy(gameObject);
        }
    }
}
