using UnityEngine;

namespace Vanchegs.PlayerLogic
{
    public class PlayerDeath : MonoBehaviour
    {

        [SerializeField] private GameObject player;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Arrow"))
            {
                Destroy(player);
            }
        }
    }
}
