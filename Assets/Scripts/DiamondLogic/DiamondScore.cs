using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Vanchegs
{
    public class DiamondScore : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreText;
        private int score = 0;
        
        void FixedUpdate()
        {
            scoreText.text = "" + score;
        }

        public void PlusScore()
        {
            score++;
        }
    }
}
