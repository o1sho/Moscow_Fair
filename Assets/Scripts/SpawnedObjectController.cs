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
            SaveObj(this.gameObject.name);
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

    private void SaveObj(string name)
    {
        switch (name)
        {
            case "+obj1(Clone)": 
                Database.Instance.countObj1++;
                ObjsController.instance.SetCountObj();
                Debug.Log("+P1 saved");
                break;
            case "+obj2(Clone)":
                Database.Instance.countObj2++;
                ObjsController.instance.SetCountObj();
                Debug.Log("+P2 saved");
                break;
            case "+obj3(Clone)":
                Database.Instance.countObj3++;
                ObjsController.instance.SetCountObj();
                Debug.Log("+P3 saved");
                break;
            case "+obj4(Clone)":
                Database.Instance.countObj4++;
                ObjsController.instance.SetCountObj();
                Debug.Log("+P4 saved");
                break;
            default: break;
        }
        Database.Instance.Save();
    }
}
