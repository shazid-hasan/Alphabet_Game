using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakControl : MonoBehaviour
{
    public Rigidbody ball;
    public GameObject ballObject;
    public Transform tablePos;
    
    private Vector3 fTable;

    public void Start()
    {
        fTable = tablePos.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Plane" || collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Gate")
        {
            //ball.AddForce(Vector3.up * 2, ForceMode.VelocityChange);
        }
        if (collision.gameObject.tag == "Gate" || collision.gameObject.tag == "AGlass" || collision.gameObject.tag == "BGlass"
            || collision.gameObject.tag == "CGlass" || collision.gameObject.tag == "DGlass" || collision.gameObject.tag == "EGlass")
        {
            //Instantiate(ballObject, fTable, Quaternion.identity);
            //Destroy(ballObject);
        }
    }
}
