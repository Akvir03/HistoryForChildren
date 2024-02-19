using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem.Sample;

namespace Valve.VR.InteractionSystem.Sample
{
    public class SceneTeleportExample : MonoBehaviour
    {
        public HoverButton hoverButton; // Assurez-vous que HoverButton est accessible

        public string sceneName = "NomDeVotreScene"; // Remplacez par le nom de votre scène

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
            SceneManager.LoadScene(sceneName);
        }
    }
}

