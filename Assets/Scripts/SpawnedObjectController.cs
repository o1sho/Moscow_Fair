using Unity.VisualScripting;
using UnityEngine;

public class SpawnedObjectController : MonoBehaviour
{
    [SerializeField] private int idObj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BasketArea" && gameObject.tag == "+")
        {
            Destroy(gameObject);
            ScoreControllerNewVer.ScoreUp();
            SaveObj(this.idObj);
            ObjsControllerNewVer.instance.SetCountObj();
            SoundController.instance.PlaySound(1);
            Debug.Log("The +product catched! Player saved health and is awarded a point!");
        }

        if (collision.gameObject.tag == "BasketArea" && gameObject.tag == "-")
        {
            Destroy(gameObject);
            DataManagerJSON_PREFS.instance.SetHpTakeDamage(-1);
            SoundController.instance.PlaySound(1);
            Debug.Log("The -product catched! Player taked damage!");
        }

        if (collision.gameObject.tag == "SpawnLine") // действия при контакте с линией спауна
        {
            SpawnController.instance.Spawn();
        }

        if (collision.gameObject.tag == "DownLine" && gameObject.tag == "+") // действия при контакте с нижний линией (+product)
        {
            Destroy(gameObject);
            DataManagerJSON_PREFS.instance.SetHpTakeDamage(-1);
            Debug.Log("The +product dropped... Player taked damage!");
        }

        if (collision.gameObject.tag == "DownLine" && gameObject.tag == "-") // действия при контакте с нижний линией (-product)
        {
            Destroy(gameObject);
            Debug.Log("The -product dropped... Player saved health!");
        }
    }

    private void SaveObj(int idObj)
    {
        if (DataManagerJSON_PREFS.instance.GetSelectedCharacter() == 0) //Заяц (x3)
        {
            DataManagerJSON_PREFS.instance.SetCountObj(idObj, +3);
        }

        if (DataManagerJSON_PREFS.instance.GetSelectedCharacter() == 1) //Медведь (x1)
        {
            DataManagerJSON_PREFS.instance.SetCountObj(idObj, +1);
        }

        if (DataManagerJSON_PREFS.instance.GetSelectedCharacter() == 2) //Выдра (x2)
        {
            DataManagerJSON_PREFS.instance.SetCountObj(idObj, +2);
        }
    }

    private void OnDisable()
    {
        DataManagerJSON_PREFS.instance.SaveGameData();
    }


}
