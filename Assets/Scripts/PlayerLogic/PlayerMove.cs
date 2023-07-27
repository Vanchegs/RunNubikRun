using UnityEngine;

namespace Vanchegs.PlayerLogic
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D playerRB;
        [SerializeField] private float speed = 3f;

        // private void Start()
        // {
        //     speed = 3f;
        // }

        private void FixedUpdate() => Move();

        // private void Move()
        // {
        //     if(Input.GetKey(KeyCode.W))
        //     {
        //         playerRB.velocity = Vector2.up * speed;
        //     }
        //     else if(Input.GetKey(KeyCode.S))
        //     {
        //         playerRB.velocity = Vector2.down * speed;
        //     }
        //     else if(Input.GetKey(KeyCode.D))
        //     {
        //         playerRB.velocity = Vector2.right * speed;
        //     }
        //     else if(Input.GetKey(KeyCode.A))
        //     {
        //         playerRB.velocity = Vector2.left * speed;
        //     }
        // }

        private void Move()
        {
            var direction = Vector2.zero;

            if (Input.GetKey(KeyCode.W))
                direction += Vector2.up;

            if (Input.GetKey(KeyCode.S))
                direction += Vector2.down;

            if (Input.GetKey(KeyCode.D))
                direction += Vector2.right;

            if (Input.GetKey(KeyCode.A))
                direction += Vector2.left;

            playerRB.velocity = direction.normalized * speed;
        }
    }
}