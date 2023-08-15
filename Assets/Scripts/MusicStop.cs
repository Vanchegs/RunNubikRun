using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vanchegs
{
    public class MusicStop : MonoBehaviour
    {
        [SerializeField] private GameObject MusikManeger;
        private PlayerLogic.PlayerDeath playerDeathFlag;

        public void Start()
        {
            //MusikManeger.SetActive(true);
        }

        private void FixedUpdate()
        {
            StopMusic();
        }

        public void StopMusic()
        {
            if (playerDeathFlag != null && playerDeathFlag.deathFlag == true)
            {
                MusikManeger.SetActive(false);
            }
            else
            {
                MusikManeger.SetActive(true);
            }
        }

        public void StartMusic()
        {
            MusikManeger.SetActive(true);
        }
    }
}
