using UnityEngine;

namespace Vanchegs.PlayerLogic
{
    public class PlayerDeath : MonoBehaviour
    {

        [SerializeField] private GameObject player;
        [SerializeField] private GameObject menuPanel;
        [SerializeField] private GameObject diamond;
        [SerializeField] private GameObject scorePanel;
        [SerializeField] private GameObject spawners;


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Arrow"))
            {
                Destroy(player);
                menuPanel.SetActive(true);
                diamond.SetActive(false);
                scorePanel.SetActive(false);
                spawners.SetActive(false);
            }
        }
    }
}
