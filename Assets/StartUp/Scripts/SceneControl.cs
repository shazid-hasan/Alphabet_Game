using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{ 

    public GameObject ball;
    public Transform pos;
    private Vector3 ballInsPos;
    private Vector3 playerPos;

    public GameObject ChBall;
    public GameObject BreakWindow;
    public GameObject ObjecttoFind;

    public GameObject standTable;
    public GameObject UICanv;



    // For Testing
    public void Start()
    {
        ballInsPos=pos.position;
    }
    public void PLayGame()
    {
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);  
        if(collision.gameObject.tag=="StartBtn")
        {
            ChBall.SetActive(true);
            BreakWindow.SetActive(true);
            ObjecttoFind.SetActive(true);

            ball.SetActive(false);
            standTable.SetActive(false);
            UICanv.SetActive(false);
        }
        else if(collision.gameObject.tag=="Wall"||collision.gameObject.tag=="Plane")
        {
              Instantiate(ball, ballInsPos, Quaternion.identity);
              Destroy(ball);
        }
        
    }

}
