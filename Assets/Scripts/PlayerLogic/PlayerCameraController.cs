using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vanchegs
{
    public class PlayerCameraController : MonoBehaviour
    {
        private Camera mainCamera;
        private float screenWidth;
        private float screenHeight;

        private void Start()
        {
            mainCamera = Camera.main;

            // Получаем разрешение экрана
            screenWidth = Screen.width;
            screenHeight = Screen.height;
        }

        private void Update()
        {
            // Получаем позицию игрока в мировых координатах
            Vector3 playerPosition = mainCamera.WorldToScreenPoint(transform.position);

            // Проверяем, выходит ли позиция игрока за границы экрана
            if (playerPosition.x < 0)
            {
                playerPosition.x = 0;
            }
            else if (playerPosition.x > screenWidth)
            {
                playerPosition.x = screenWidth;
            }

            if (playerPosition.y < 0)
            {
                playerPosition.y = 0;
            }
            else if (playerPosition.y > screenHeight)
            {
                playerPosition.y = screenHeight;
            }

            // Обновляем позицию игрока в мировых координатах
            transform.position = mainCamera.ScreenToWorldPoint(playerPosition);
        }
    }
}
