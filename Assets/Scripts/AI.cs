using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{

    GameObject player;
    CircleCollider2D trigger;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        trigger = gameObject.GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col == player.GetComponent<CircleCollider2D>()) {
            player.GetComponent<ScoreKeeper>().HP -= 5;
        }
    }
}
