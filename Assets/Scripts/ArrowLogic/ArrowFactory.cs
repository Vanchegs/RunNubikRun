using System.Collections;
using UnityEngine;

namespace Vanchegs.ArrowLogic
{
    public class ArrowFactory : MonoBehaviour
    {
        [SerializeField] private int spawnPointX;
        [SerializeField] private float spawnRate;
        [SerializeField] private Arrow arrowPrefab;
        [SerializeField] private int poolCount = 20;
        [SerializeField] private bool autoExpand;
        [SerializeField] private ArrowConfig arrowsConfig;

        private PoolMono<Arrow> pool;

        private void Start()
        {
            pool = new PoolMono<Arrow>(arrowPrefab, poolCount, transform)
            {
                autoExpand = this.autoExpand
            };

            StartCoroutine(SpawningArrows());
        }

        private IEnumerator SpawningArrows()
        {
            while (true)
            {
                CreateNewArrow();

                yield return new WaitForSeconds(spawnRate);
            }
        }

        private void CreateNewArrow()
        {
            var newPosition = new Vector3(spawnPointX, Random.Range(-4.5f, 4.5f));

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