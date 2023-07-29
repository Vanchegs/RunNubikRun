using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vanchegs
{
    public class DiamondSpawn : MonoBehaviour
    {
        [SerializeField] private Transform[] diamandPoints = new Transform[2];
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
                yield return new WaitForSeconds(1);
            }
        }

        private void RetransformDiamond()
        {
            diamondPrefab.diamondTransform = diamandPoints[Random.Range(0, 1)];
            diamondPrefab.DiamondIsActive(diamondPrefab.gameObject, true);
        }
    }
}
