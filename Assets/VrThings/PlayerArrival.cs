using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerArrival : MonoBehaviour
{
    private string currentSceneName;

    private void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
        SetPlayerPositionBasedOnScene(currentSceneName);
    }

    private void Update()
    {
        string newSceneName = SceneManager.GetActiveScene().name;
        if (newSceneName != currentSceneName)
        {
            currentSceneName = newSceneName;
            SetPlayerPositionBasedOnScene(currentSceneName);
        }
    }

    private void SetPlayerPositionBasedOnScene(string sceneName)
    {
        Vector3 arrivalPosition;

        // Vérifie le nom de la scène
        if (sceneName == "JurassicScene")
        {
            arrivalPosition = new Vector3(27, 1, 18);
        }
        else if (sceneName == "Scene_Antique")
        {
            arrivalPosition = new Vector3(13, 1, 120);
        }
        else
        {

            arrivalPosition = new Vector3(420, 0, 277);
        }

        transform.position = arrivalPosition;
    }
}
