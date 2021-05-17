using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeperGUI : MonoBehaviour
{

    ScoreKeeper player;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<ScoreKeeper>();
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "HP: " + player.HP + "\nAmmo: " + player.Ammo + "\nGold: " + player.Gold;
    }
}
