using UnityEngine;

namespace Vanchegs.PlayerLogic
{
    public class PlayerMove : MonoBehaviour
    {

        [SerializeField] private Rigidbody2D playerRB;
        [SerializeField] private float speed;

        void Start()
        {
            speed = 3f;
        }
    
        void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            if(Input.GetKey(KeyCode.W))
            {
                playerRB.velocity = Vector2.up * speed;
            }
            else if(Input.GetKey(KeyCode.S))
            {
                playerRB.velocity = Vector2.down * speed;
            }
            else if(Input.GetKey(KeyCode.D))
            {
                playerRB.velocity = Vector2.right * speed;
            }
            else if(Input.GetKey(KeyCode.A))
            {
                playerRB.velocity = Vector2.left * speed;
            }
        }
    }
}
