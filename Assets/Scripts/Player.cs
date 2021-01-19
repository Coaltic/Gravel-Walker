using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 originalPosition;
    public GameObject canvas;
    public float timer = 3.0f;

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
            gameObject.transform.position = originalPosition;
            //gameObject.transform.position = new Vector3(0, 1, 0);
        }
        else if (other.tag == "Checkpoint1")
        {
            originalPosition = gameObject.transform.position;
            Debug.Log("Checkpoint 1 reached");
            canvas.SetActive(true);
            gameObject.transform.position = originalPosition;   

        }
        else if (other.tag == "Checkpoint2")
        {
            originalPosition = gameObject.transform.position;
            Debug.Log("Checkpoint 2 reached");
            canvas.SetActive(true);
            gameObject.transform.position = originalPosition;


        }
        else if (other.tag == "Checkpoint3")
        {
            originalPosition = gameObject.transform.position;
            Debug.Log("Checkpoint 3 reached");
            canvas.SetActive(true);
            gameObject.transform.position = originalPosition;

        }
        
    }

    public void OnTriggerExit(Collider other)
    {
        canvas.SetActive(false);
    }
}
