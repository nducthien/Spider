using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMovingY : MonoBehaviour {

    private Rigidbody2D enemyBody;
    public bool checkBottom;
    // Start is called before the first frame update
    void Start()
    {
        enemyBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveForeY = 0f;
        if (checkBottom)
        {
            moveForeY = 2f;
        } else
        {
            moveForeY = -2f;
        }
        enemyBody.velocity = new Vector2(0, transform.localScale.y) * moveForeY;
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Ground")
        {
            checkBottom = false;
        }

        if (target.gameObject.tag == "minhi")
        {
            checkBottom = true;
        }
    }
}
