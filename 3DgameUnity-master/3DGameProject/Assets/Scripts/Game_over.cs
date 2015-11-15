using UnityEngine;
using System.Collections;

public class Game_over : MonoBehaviour {

    private bool playerDead = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       /* Collision collision;
        if (collision.gameObject.name == "Fire")
        {
            playerDead = true;
            EndGame();
        }*/
	
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            playerDead = true;
            EndGame();
        }
    }
    void EndGame()
    {
        if(playerDead)
        {
            Application.LoadLevel("Game_Over");
        }
    }
}
