using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int record;
    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
           
            record = PlayerPrefs.GetInt("HighScore");
        }

        PlayerPrefs.SetInt("HighScore", record);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text highScore = this.GetComponent<Text>();
        highScore.text = "High Score: " + record;

        //Update the PlayerPrefs HighScore if necessary
        if (record > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", record);
        }
    }
}
