using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //private Color _colorEnter;

    private void Start()
    {
        //_colorEnter = GetComponent<MeshRenderer>().material.color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }

    /*private void OnCollisionExit(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = _colorEnter;
    }*/
}
