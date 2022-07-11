using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanCatcher : MonoBehaviour
{
    public GameObject scoreText;
    public ParticleSystem confetti;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Can"))
        {
            Destroy(other.gameObject);
            scoreText.GetComponent<ScoreKeeperCans>().scoreValue += 5;
            scoreText.GetComponent<ScoreKeeperCans>().UpdateScore();

            ShootCannon();
        }
    }

    public void ShootCannon()
    {
        confetti.Play();
    }
}
