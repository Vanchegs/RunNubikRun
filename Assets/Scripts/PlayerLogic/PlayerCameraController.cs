using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vanchegs
{
    public class PlayerCameraController : MonoBehaviour
    {
        private Camera mainCamera;
        private float minX, maxX, minY, maxY;
        private float playerWidth, playerHeight;

        void FixedUpdate()
        {
            mainCamera = Camera.main;

            // Получение размеров экрана
            float screenHeight = 2f * mainCamera.orthographicSize;
            float screenWidth = screenHeight * mainCamera.aspect;

            // Получение размеров игрока
            playerWidth = GetComponent<Renderer>().bounds.size.x;
            playerHeight = GetComponent<Renderer>().bounds.size.y;

            // Рассчет границ экрана с учетом размера игрока
            minX = -(screenWidth / 2f) + (playerWidth / 2f);
            maxX = (screenWidth / 2f) - (playerWidth / 2f);
            minY = -(screenHeight / 2f) + (playerHeight / 2f);
            maxY = (screenHeight / 2f) - (playerHeight / 2f);
            float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
            float clampedY = Mathf.Clamp(transform.position.y, minY, maxY);
            transform.position = new Vector3(clampedX, clampedY, transform.position.z);
        }
    }
}
