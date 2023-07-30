using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vanchegs
{
    public class DiamondSpawn : MonoBehaviour
    {
        [SerializeField] private Transform[] diamandPoints;
        [SerializeField] private Diamond diamondPrefab;
        private int coolDown = 5;

        private void Start()
        {
            StartCoroutine("SpawningDiamonds");
            RetransformDiamond();
        }

        private IEnumerator SpawningDiamonds()
        {
            while(true)
            {
                if (diamondPrefab.diamondIsTake == true)
                {
                    RetransformDiamond();
                    yield return new WaitForSeconds(coolDown);
                }
                else
                {
                    yield return new WaitForEndOfFrame();
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
