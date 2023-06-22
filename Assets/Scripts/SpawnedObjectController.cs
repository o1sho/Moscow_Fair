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
            Database.Instance.hp--;
            Debug.Log("The -product catched! Player taked damage!");
        }

        if (collision.gameObject.tag == "SpawnLine") // �������� ��� �������� � ������ ������
        {
            SpawnController.instance.Spawn();
        }

        if (collision.gameObject.tag == "DownLine" && gameObject.tag == "+") // �������� ��� �������� � ������ ������ (+product)
        {
            Destroy(gameObject);
            Database.Instance.hp--;
            Debug.Log("The +product dropped... Player taked damage!");
        }

        if (collision.gameObject.tag == "DownLine" && gameObject.tag == "-") // �������� ��� �������� � ������ ������ (-product)
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
                if (Database.Instance.selectedCharacter == 1) Database.Instance.countObj1 = Database.Instance.countObj1 + 2;
                else Database.Instance.countObj1++;
                ObjsController.instance.SetCountObj();
                Debug.Log("+P1 saved");
                break;
            case "+obj2(Clone)":
                if (Database.Instance.selectedCharacter == 1) Database.Instance.countObj2 = Database.Instance.countObj2 + 2;
                else Database.Instance.countObj2++;
                ObjsController.instance.SetCountObj();
                Debug.Log("+P2 saved");
                break;
            case "+obj3(Clone)":
                if (Database.Instance.selectedCharacter == 1) Database.Instance.countObj3 = Database.Instance.countObj3 + 2;
                else Database.Instance.countObj3++;
                ObjsController.instance.SetCountObj();
                Debug.Log("+P3 saved");
                break;
            case "+obj4(Clone)":
                if (Database.Instance.selectedCharacter == 1) Database.Instance.countObj4 = Database.Instance.countObj4 + 2;
                else Database.Instance.countObj4++;
                ObjsController.instance.SetCountObj();
                Debug.Log("+P4 saved");
                break;
            default: break;
        }
        Database.Instance.Save();
    }
}
