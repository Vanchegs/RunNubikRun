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
        [SerializeField] private TMP_Text menuScoreText;
        [SerializeField] private TMP_Text menuHighestScoreText;
        private float score = 0;
        private float highestScore = 0;

        private void Start()
        {
            LoadHighScore();
            scoreText.text = "" + score;
            highestScoreText.text = "" + highestScore;
            menuScoreText.text = "—чет:" + score;
            menuHighestScoreText.text = "–екорд:" + highestScore;
        }

        private void PlusScore()
        {
            score++;
        }

        private void UpdateHighestScore()
        {
            if (score > highestScore)
            {
                 highestScore = score;
                 highestScoreText.text = "" + highestScore;
                 SaveHighScore();
            }
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
                menuScoreText.text = "—чет:" + score;
                menuHighestScoreText.text = "–екорд:" + highestScore;
                UpdateHighestScore();
            }
        }
    }
}
