using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{
    private void Awake()
    {
        //PlayerPrefs.SetInt("Score", 0);
        int score = PlayerPrefs.GetInt("Score");
        Text text = this.GetComponent<Text>();
        text.text = "Your Score:" + score;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
