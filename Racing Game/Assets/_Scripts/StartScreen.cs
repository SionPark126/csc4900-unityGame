using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void playGame()
    //{
    //    SceneManager.LoadScene("_Scene_0");
    //}

    public void OnClick()
    {
        //iceSound.Play();
        Invoke("playGame", 1f);
        SceneManager.LoadScene("_Scene_0");

    }
}
