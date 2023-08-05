using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Vanchegs
{
    public class DiamondScore : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private TMP_Text highestScoreText;
        private float score = 0;
        private float highestScore = 0;

        private void Start()
        {
            LoadHighScore();
        }

        private void FixedUpdate()
        {
            scoreText.text = "" + score;
            highestScoreText.text = "" + highestScore;

            if (score > highestScore)
            {
                highestScore = score;
                SaveHighScore();
            }
        }

        public void PlusScore()
        {
            score++;
        }

        private void SaveHighScore()
        {
            PlayerPrefs.SetFloat("HighScore", highestScore);
            PlayerPrefs.Save();
        }

        private void LoadHighScore()
        {
            if (PlayerPrefs.HasKey("HighScore"))
            {
                highestScore = PlayerPrefs.GetFloat("HighScore");
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                PlusScore();
            }
        }
    }
}
