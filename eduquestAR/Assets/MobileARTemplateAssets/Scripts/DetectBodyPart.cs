using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBodyPart : MonoBehaviour
{
    public GameObject infoPanel;

    void Start ()
    {

    }

    void OnCollisionEnter (Collision collision)
    {
        if (collision.collider.CompareTag("BodyPart"))
        {
            
        }
    }
}
