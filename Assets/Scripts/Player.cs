using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{    
    public GameObject respawnLocation;
    Vector3 winner = new Vector3(-1.8f, 7.0f, -75.0f);
    Vector3 originalPosition;
    public GameObject canvas;

    public float timer = 3.0f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 respawnLocation =  originalPosition - gameObject.transform.position;
        Debug.Log("TRIGGERED: " + other.tag);

        if (other.tag == "Killbox")
        {
            Debug.Log("About to reset player");
            gameObject.GetComponent<CharacterController>().Move(respawnLocation);
            //gameObject.transform.position = new Vector3(0, 1, 0);
        }
        else if (other.tag == "Checkpoint")
        {
            originalPosition = gameObject.transform.position;
            gameObject.transform.position = originalPosition;
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
        else if (other.tag == "Teleporter")
        {
            Debug.Log("TRIGGERED: " + other.tag);
            gameObject.GetComponent<CharacterController>().Move(winner);
        }
        
    }

    public void OnTriggerExit(Collider other)
    {
        canvas.SetActive(false);
    }
}
