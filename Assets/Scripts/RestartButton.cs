using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Vanchegs
{
    public class RestartButton : MonoBehaviour
    {
        public void StartScene()
        {
            SceneManager.LoadSceneAsync("GameplayScene");
        }
    }
}
