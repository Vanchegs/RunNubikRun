using UnityEngine;

namespace Vanchegs.PlayerLogic
{
    public class PlayerMove : MonoBehaviour
    {
        private float speed = 3f;
        [SerializeField] private Joystick myJoystick;
        private Rigidbody2D rb;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            Vector2 movement = new Vector2(myJoystick.Horizontal, myJoystick.Vertical);
            rb.velocity = movement * speed;
        }
    }
}