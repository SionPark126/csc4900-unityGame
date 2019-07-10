using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCredits : MonoBehaviour
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
        //iceSound.Play();
        // Invoke("playGame", 1f);
        // SceneManager.LoadScene("_Scene_0");
        modalWindow.SetActive(true);

    }

    public void OnClickExit()
    {
        modalWindow.SetActive(false);
    }
}
