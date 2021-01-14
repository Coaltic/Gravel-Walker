using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 originalPosition;

    void Start()
    {
        originalPosition = gameObject.transform.position;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGERED: " + other.tag);

        if (other.tag == "Killbox")
        {
            Debug.Log("About to reset player");
            //gameObject.transform.position = originalPosition;
            gameObject.transform.position = new Vector3(0, 1, 0);
        }
    }
}
