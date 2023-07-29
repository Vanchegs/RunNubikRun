using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vanchegs
{
    public class Diamond : MonoBehaviour
    {
        private Transform diamondTransform;

        public void DiamondIsActive(GameObject diamond, bool isActive)
        {
            diamond.SetActive(isActive);
        }
    }
}
