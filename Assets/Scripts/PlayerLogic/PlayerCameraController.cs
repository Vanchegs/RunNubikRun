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

            // �������� ���������� ������
            screenWidth = Screen.width;
            screenHeight = Screen.height;
        }

        private void Update()
        {
            // �������� ������� ������ � ������� �����������
            Vector3 playerPosition = mainCamera.WorldToScreenPoint(transform.position);

            // ���������, ������� �� ������� ������ �� ������� ������
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

            // ��������� ������� ������ � ������� �����������
            transform.position = mainCamera.ScreenToWorldPoint(playerPosition);
        }
    }
}
