using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3Controller : MonoBehaviour {

    private Transform bullet3;

    public float speed;

    // Use this for initialization
    void Start () {

        bullet3 = GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        bullet3.position += Vector3.up * speed - Vector3.right * speed / 2;

        if (bullet3.position.y >= 10)
        {

            Destroy(gameObject);

        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        else if (other.tag == "Base")
        {

            Destroy(gameObject);

        }


    }

}
