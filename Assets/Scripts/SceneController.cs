using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ChangeScene(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }
}
