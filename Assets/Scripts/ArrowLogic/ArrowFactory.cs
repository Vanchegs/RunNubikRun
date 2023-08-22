using System.Collections;
using UnityEngine;

namespace Vanchegs.ArrowLogic
{
    public class ArrowFactory : MonoBehaviour
    {
        [SerializeField] private int spawnPointX;
        [SerializeField] private Arrow arrowPrefab;
        [SerializeField] private int poolCount = 20;
        [SerializeField] private bool autoExpand;
        [SerializeField] private ArrowConfig arrowsConfig;
        private float spawnRate = 2.5f;
        private PoolMono<Arrow> pool;
        
        private void Start()
        {
            pool = new PoolMono<Arrow>(arrowPrefab, poolCount, transform)
            {
                autoExpand = this.autoExpand
            };

            StartCoroutine(SpawningArrows());
            StartCoroutine(DecreaseSpawnRate());
        }

        private IEnumerator SpawningArrows()
        {
            while (true)
            {
                CreateNewArrow();

                yield return new WaitForSeconds(spawnRate);
            }
        }

        private IEnumerator DecreaseSpawnRate()
        {
            while(spawnRate > 1.5f)
            {
                spawnRate = spawnRate - 0.1f;

                yield return new WaitForSeconds(5);
            }
        }

        private void CreateNewArrow()
        {
            var newPosition = new Vector3(spawnPointX, Random.Range(-4.5f, 3.3f));

            var arrow = pool.GetFreeElement();

            if(spawnPointX > 0)
            {
                arrow.arrowRenderer.flipX = true;
            }

            if (arrow == null)
                return;

            arrow.gameObject.SetActive(true);
            arrow.transform.position = newPosition;
            arrow.transform.SetParent(transform);
            arrow.InitArrow(arrowsConfig);
        }
    }
}