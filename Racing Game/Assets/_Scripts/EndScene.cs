using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public GameObject modalWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {

        SceneManager.LoadScene("_Scene_0");
        //modalWindow.SetActive(false);

    }
    public void OnClickExit()
    {
        Application.Quit();
    }
}
