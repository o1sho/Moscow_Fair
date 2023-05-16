using UnityEngine;

public class SpawnedObjectController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ScoreController.ScoreUp();
        }
    }
}
