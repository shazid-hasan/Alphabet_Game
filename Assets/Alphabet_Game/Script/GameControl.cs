using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> window = new List<GameObject>();
    public GameObject slideWindow1;
    bool move = false;

    public GameObject effect;
    int levelCount=1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0,LoadSceneMode.Single);
            
        }
        if(window.Count==0&&!move)
        {           
            slideWindow1.transform.localPosition = new Vector3(slideWindow1.transform.localPosition.x, 1, slideWindow1.transform.localPosition.z);
            move = true;
            levelCount++;
            SceneManager.LoadSceneAsync(levelCount,LoadSceneMode.Additive);
        }
    }
}
