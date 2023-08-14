using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vanchegs
{
    public class MusikStop : MonoBehaviour
    {
        [SerializeField] private GameObject MusikManeger;

        private void FixedUpdate()
        {
            Stop();
        }

        public void Stop()
        {
            if(PlayerLogic.PlayerDeath.deathFlag == true)
            {
                MusikManeger.SetActive(false);
            }
        }
    }
}
