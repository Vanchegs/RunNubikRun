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
            ControlThroughJoystick();
        }

        void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                ControlThroughKeyboard();
            }
            else
            {
                ControlThroughJoystick();
            }
        }

        private void ControlThroughJoystick()
        {
            if (myJoystick != null)
            {
                rb.velocity = new Vector2(myJoystick.Horizontal, myJoystick.Vertical) * speed;
            }
        }

        private void ControlThroughKeyboard()
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
        }
    }
}