using System;
using UnityEngine;

namespace Vanchegs.ArrowLogic
{
    public class Arrow : MonoBehaviour
    {
        private ArrowConfig arrowConfig;

        private new Rigidbody2D rigidbody2D;
        public SpriteRenderer arrowRenderer;
        private PoolMono<Arrow> poolMono;

        private void Awake()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        public void Constructor<T>(PoolMono<T> poolMono1) where T : MonoBehaviour
        {
            poolMono = poolMono1 as PoolMono<Arrow>;
        }

        public void InitArrow(ArrowConfig arrowConfig)
        {
            this.arrowConfig = arrowConfig;

            rigidbody2D.AddForce(arrowConfig.ArrowsDirection * arrowConfig.ArrowsSpeed, ForceMode2D.Impulse);
        }

        private void Update()
        {
            if (transform.position.x >= 30 || transform.position.x <= -30)
                poolMono.ReturnToPool(this);
            
            if (transform.position.x >= 30 || transform.position.y <= -30)
                poolMono.ReturnToPool(this);
        }
    }
}