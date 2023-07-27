using UnityEngine;

namespace PlayerLogic
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
