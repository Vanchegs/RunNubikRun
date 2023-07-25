using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    

    public class ArrowFactory : MonoBehaviour
    {
        [SerializeField] private int spawnPointX;
        [SerializeField] private float spawnRate;
        [SerializeField] private Arrow arrowPrefab;
        [SerializeField] private int poolCount = 20;
        [SerializeField] private bool autoExpand = false;

        private PoolMono<Arrow> pool;

        [SerializeField] private ArrowConfig arrowsConfig;
        
        private void Start()
        {
            StartCoroutine(SpawningArrows());
            this.pool = new PoolMono<Arrow>(this.arrowPrefab, this.poolCount, this.transform);
            this.pool.autoExpand = this.autoExpand;
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
            Arrow arrow = pool.GetFreeElement();
            if(arrow != null)
            { 
                arrow.gameObject.SetActive(true);
                arrow.transform.position = newPosition;
                //arrow.transform.SetParent(transform);
                arrow.InitArrow(arrowsConfig);
            }
        }
    }
