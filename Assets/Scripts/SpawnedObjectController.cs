using UnityEngine;

public class SpawnedObjectController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && gameObject.tag == "+")
        {
            Destroy(gameObject);
            ScoreController.ScoreUp();
        }

        if (collision.gameObject.tag == "Player" && gameObject.tag == "-")
        {
            Destroy(gameObject);
            PlayerController.instance.health--;
            Debug.Log("Player take damage!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SpawnLine")
        {
            SpawnController.instance.Spawn();
        }
    }
}
