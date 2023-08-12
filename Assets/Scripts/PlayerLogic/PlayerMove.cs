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
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            float moveJoystickHorizontal = myJoystick.Horizontal;
            float moveJoystickVertical = myJoystick.Vertical;

            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            Vector2 joystickMovement = new Vector2(moveJoystickHorizontal, moveJoystickVertical);
            rb.velocity = movement * speed;
            rb.velocity = joystickMovement * speed;
        }
    }
}