using UnityEngine;

namespace ArrowLogic
{
    public class Arrow : MonoBehaviour
    {
        private ArrowConfig arrowConfig;

        private new Rigidbody2D rigidbody2D;

        private void Awake()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        public void InitArrow(ArrowConfig arrowConfig)
        {
            this.arrowConfig = arrowConfig;

            rigidbody2D.AddForce(arrowConfig.ArrowsDirection * arrowConfig.ArrowsSpeed, ForceMode2D.Impulse);
        }
    }
}
