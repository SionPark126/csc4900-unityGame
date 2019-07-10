using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    private float startTime;
    static public int timeAccrued;
    public Text timeText;
    private float minutes;
    private float seconds;
    public AudioSource carSound;
   

    [Header("Set in Inspector")]
    public GameObject[] prefabEnemies;
  

    public GameObject prefabDiamond;

    public static float enemySpawnPerSecond = 3f;
    public static float diamondSeconds = 5f;
    private float[] xPositions = { -5, -1.5f , 2, 5.5f };
    static int level = 0;

    private void Awake()
    {
        carSound.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        //Add cars
        startTime = Time.time;
        GameObject scoreBoard = GameObject.Find("TimeCounter");

        timeText = scoreBoard.GetComponent<Text>();
        Invoke("SpawnEnemy", 1f);
        Invoke("SpawnDiamond", 1f);
        Invoke("LevelUp", 15f);
    }

    public void SpawnEnemy()
    {
        int ndx = Random.Range(0, prefabEnemies.Length);
        GameObject go = Instantiate<GameObject>(prefabEnemies[ndx]);

        Vector3 carPos = new Vector3(xPositions[Random.Range(0, 4)], 22, 0);
        go.transform.position = carPos;
        Invoke("SpawnEnemy", enemySpawnPerSecond);
    }

    public void SpawnDiamond()
    {
        GameObject go = Instantiate(prefabDiamond);
        Vector3 goPos = new Vector3(xPositions[Random.Range(0, 4)], 22, 0);
        go.transform.position = goPos;

        Invoke("SpawnDiamond", diamondSeconds);
       
    }


    // Update is called once per frame
    void Update()
    {
        //currentRecord = GameObject.Find("HighScore");
        timeAccrued = Mathf.RoundToInt(Time.time - startTime);
        //minutes = Mathf.Floor(timeAccrued / 60);
        //seconds = timeAccrued % 60;
        //timeText.text = minutes.ToString() + ":" + seconds.ToString();

        timeText.text = "Time: " + timeAccrued.ToString();

        //Update the PlayerPrefs HighScore if necessary
        if (HighScore.record < timeAccrued)
            HighScore.record = timeAccrued;
                 PlayerPrefs.SetInt("Score", timeAccrued);


      
    }


    public void LevelUp()
    {
        level++;
        if (level < 4)
        {
            enemySpawnPerSecond = (float)(enemySpawnPerSecond - (level * 0.3));
            //diamondSeconds = (float)(diamondSeconds - (level * 0.3));

            Enemy.enemySpeed += 0.5f;
            Diamond.diamondSpeed += 0.2f;
        }
        Invoke("LevelUp", 10f);

    }

}
