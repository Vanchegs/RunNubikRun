using UnityEngine;

namespace Vanchegs.PlayerLogic
{
    public class PlayerMove : MonoBehaviour
    {
        private float speed = 3f;
        [SerializeField] private FloatingJoystick myJoystick;
        private Rigidbody2D rb;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
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
                rb.velocity = new Vector2(myJoystick.Horizontal * speed, myJoystick.Vertical * speed);
            }
        }

        private void ControlThroughKeyboard()
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
        }
    }
}