using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScrollUp()
    {
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(y + 1);
    }

    public void ScrollDown()
    {
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(y - 1);
    }
}
