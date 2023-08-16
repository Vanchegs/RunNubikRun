using UnityEngine;
using YG;

namespace Vanchegs.PlayerLogic
{
    public class PlayerDeath : MonoBehaviour
    {

        [SerializeField] private GameObject player;
        [SerializeField] private GameObject menuPanel;
        [SerializeField] private GameObject diamond;
        [SerializeField] private GameObject scorePanel;
        [SerializeField] private GameObject spawners;
        [SerializeField] private GameObject joystick;
        public bool deathFlag = false;


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Arrow"))
            {
                player.SetActive(false);
                deathFlag = true;
                menuPanel.SetActive(true);
                joystick.SetActive(false);
                diamond.SetActive(false);
                scorePanel.SetActive(false);
                spawners.SetActive(false);
                YandexGame.FullscreenShow();
            }
        }
    }
}
