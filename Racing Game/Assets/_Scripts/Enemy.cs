using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected BoundsCheck bndCheck;
    static public float enemySpeed = 4f;

    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }

    // Start is called before the first frame update
    void Start()
    {

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
    public virtual void Move()
    {
        transform.Translate(new Vector3(0, -1, 0) * enemySpeed * Time.deltaTime);
    }

}
