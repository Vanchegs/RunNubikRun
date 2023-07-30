using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vanchegs
{
    public class Diamond : MonoBehaviour
    {
        [SerializeField] GameObject diamondGO;
        public Transform diamondTransform;
        public bool diamondIsTake = false;

        public void DiamondIsActive(GameObject diamond, bool isActive)
        {
            diamond.SetActive(isActive);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Player"))
            {
                DiamondIsActive(diamondGO, false);
                diamondIsTake = true;
            }
        }
    }
}
