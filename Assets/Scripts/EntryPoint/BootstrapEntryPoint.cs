using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootstrapEntryPoint : MonoBehaviour
{
    [SerializeField] private float loadingDuration;
    private IEnumerator Start()
    {
        // Init Loading Screen Service
        // Init Dependency Injectrion Service (ex. Zenject)
        // Init UI Service
        // Init Input Service
        // Init Cloud Service
        // Init Localization Service
        // Init Storage Service
        // Init Scene Management Service

        while (loadingDuration > 0)
        {
            loadingDuration -= Time.deltaTime;
            Debug.Log("Start loading...");
            yield return null;
        }

        DataManagerJSON_PREFS.instance.SaveGameData();
        Debug.Log("All application services are initialized!");

        var buildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(buildIndex + 1);
    }
}
