using UnityEngine;
using System.Collections;

public class MoneyManager : MonoBehaviour
{

    public GameObject coin;
    public AudioSource moneySound;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(coin);
            CompleteProject.ScoreManager.score++;
            moneySound.Play();
        }
    }
}
