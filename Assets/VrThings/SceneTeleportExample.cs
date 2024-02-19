using UnityEngine;
using UnityEngine.SceneManagement;
// Pas besoin de "using Valve.VR.InteractionSystem.Sample;" si vous êtes déjà dans cet espace de noms

namespace Valve.VR.InteractionSystem.Sample
{
    public class SceneTeleportExample : MonoBehaviour
    {
        public HoverButton hoverButton;
        public string sceneName = "NomDeVotreScene";
        public Vector3 arrivalPosition = new Vector3(-19, 0, 3); // L'emplacement où le joueur doit apparaître dans la nouvelle scène

        private void Start()
        {
            hoverButton.onButtonDown.AddListener(delegate { OnButtonDown(); });
        }

        private void OnButtonDown()
        {
            TeleportToScene();
        }

        private void TeleportToScene()
        {
            // Stocker l'emplacement d'arrivée
            PlayerPrefs.SetFloat("ArrivalPosX", arrivalPosition.x);
            PlayerPrefs.SetFloat("ArrivalPosY", arrivalPosition.y);
            PlayerPrefs.SetFloat("ArrivalPosZ", arrivalPosition.z);

            // Charger la scène
            SceneManager.LoadScene(sceneName);
        }
    }
}
