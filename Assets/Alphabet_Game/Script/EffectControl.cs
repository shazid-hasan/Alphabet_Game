using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectControl : MonoBehaviour
{
    private IEnumerator coroutine;
    public GameControl gc;

    private void Start()
    {
       // gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControl>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag=="SetObject")
        {
            gc.gameObject.SetActive(true);
            coroutine = WaitAndPrint(2f);
            StartCoroutine(coroutine);
        }
    }

    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gc.gameObject.SetActive(false);
        StopCoroutine(coroutine);
    }

}
