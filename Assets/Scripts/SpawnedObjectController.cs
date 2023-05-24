using UnityEngine;

public class SpawnedObjectController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BasketArea" && gameObject.tag == "+")
        {
            Destroy(gameObject);
            ScoreController.ScoreUp();
            Debug.Log("The +product catched! Player saved health and is awarded a point!");
        }

        if (collision.gameObject.tag == "BasketArea" && gameObject.tag == "-")
        {
            Destroy(gameObject);
            PlayerController.instance.TakeDamage(1);
            Debug.Log("The -product catched! Player taked damage!");
        }

        if (collision.gameObject.tag == "SpawnLine") // действия при контакте с линией спауна
        {
            SpawnController.instance.Spawn();
        }

        if (collision.gameObject.tag == "DownLine" && gameObject.tag == "+") // действия при контакте с нижний линией (+product)
        {
            Destroy(gameObject);
            PlayerController.instance.TakeDamage(1);
            Debug.Log("The +product dropped... Player taked damage!");
        }

        if (collision.gameObject.tag == "DownLine" && gameObject.tag == "-") // действия при контакте с нижний линией (-product)
        {
            Destroy(gameObject);
            Debug.Log("The -product dropped... Player saved health!");
        }
    }
}
