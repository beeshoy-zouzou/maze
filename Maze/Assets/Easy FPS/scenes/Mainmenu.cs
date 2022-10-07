using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 public void enter()
    {
        Debug.Log("bye bye");
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

public void quit()
    {
    Debug.Log("bye bye");
    Application.Quit();
    }
    public void credit()
    {
    SceneManager.LoadScene(2);
    }
}
