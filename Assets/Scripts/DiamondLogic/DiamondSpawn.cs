using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vanchegs
{
    public class DiamondSpawn : MonoBehaviour
    {
        [SerializeField] private Transform[] diamandPoints;
        [SerializeField] private Diamond diamondPrefab;

        private void Start()
        {
            StartCoroutine("SpawningDiamonds");
        }

        private IEnumerator SpawningDiamonds()
        {
            while(true)
            {
                RetransformDiamond();
                if(diamondPrefab.diamondIsTake == true)
                {
                    yield return new WaitForSeconds(5);
                }
            }
        }

        private void RetransformDiamond()
        {
            diamondPrefab.diamondTransform.position = diamandPoints[Random.Range(0, diamandPoints.Length)].position;
            diamondPrefab.DiamondIsActive(diamondPrefab.gameObject, true);
        }
    }
}
