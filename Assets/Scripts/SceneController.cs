using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ChangeScene(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }

    public void ResetScene()
    {
        int activeIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeIndex);
    }
}
