using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CarMovement : MonoBehaviour
{

    Rigidbody2D rb;
    public AudioClip carCrashSound;

    static public float carSpeed  = 3f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 20));
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, -20));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -20));
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, 20));
        }

        //change transform.position based on the axes
        Vector3 pos = transform.position;
        pos.x += xAxis * carSpeed * Time.deltaTime;
        pos.y += yAxis * carSpeed * Time.deltaTime;
        transform.position = pos;

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyCar")
        {
            AudioSource.PlayClipAtPoint(carCrashSound, 0.9f * Camera.main.transform.position + 0.1f * transform.position, 7f);
           
            Destroy(gameObject);
            //modalWindow.SetActive(true)
            //int score = Main.timeAccrued;        

            SceneManager.LoadScene("_End_Scene");
           


        }
      

    }
}
