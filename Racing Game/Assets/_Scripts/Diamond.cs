using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diamond : MonoBehaviour
{
    public AudioClip diamondCollectSound;
    private BoundsCheck bndCheck;
    static public float diamondSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (bndCheck != null && bndCheck.offDown)
        {
            Destroy(gameObject);
        }
    }

    public void Move()
    {
        transform.Translate(new Vector3(0, -1, 0) * diamondSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(gameObject);
        if (collision.gameObject.tag == "HeroCar")
        {
            AudioSource.PlayClipAtPoint(diamondCollectSound, 0.9f * Camera.main.transform.position + 0.1f * transform.position, 7f);
            Destroy(gameObject);
            CarMovement.carSpeed += 1f;
           

        }
    }
}
