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
            scoreText.text = "" + score;
        }

        private void FixedUpdate()
        {
            highestScoreText.text = "" + highestScore;

            
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
                scoreText.text = "" + score;
                if (score > highestScore)
                {
                    highestScore = score;
                    SaveHighScore();
                }
            }
        }
    }
}
