using System.Collections.Generic;
using UnityEngine;

namespace Vanchegs.ArrowLogic
{
    public class PoolMono<T> where T : MonoBehaviour
    {
        public T prefab { get; }
        public bool autoExpand { get; set; }
        public Transform container { get; }

        private List<T> pool;

        public PoolMono(T prefab, int count)
        {
            this.prefab = prefab;
            this.container = null;

            this.CreatePool(count);
        }

        public PoolMono(T prefab, int count, Transform container)
        {
            this.prefab = prefab;
            this.container = container;

            this.CreatePool(count);
        }

        public void ReturnToPool(T target)
        {
            if (target != null)
            {
                target.gameObject.SetActive(false);
                target.transform.position = Vector3.zero;
            }
        }

        private void CreatePool(int count)
        {
            this.pool = new List<T>();

            for (int i = 0; i < count; i++)
            {
                this.CreateObject();
            }
        }

        private T CreateObject(bool isActiveByDefault = false)
        {
            var createObject = Object.Instantiate(this.prefab, this.container);
            createObject.gameObject.SetActive(isActiveByDefault);

            createObject.GetComponent<Arrow>().Constructor(this);

            this.pool.Add(createObject);
            return createObject;
        }

        public bool HasFreeElement(out T element)
        {
            foreach (var mono in pool)
            {
                if (!mono.gameObject.activeInHierarchy)
                {
                    element = mono;
                    mono.gameObject.SetActive(true);
                    return true;
                }
            }

            element = null;
            return false;
        }

        public T GetFreeElement()
        {
            if (this.HasFreeElement(out var element))
            {
                return element;
            }

            if (this.autoExpand)
            {
                return this.CreateObject(isActiveByDefault: true);
            }

            throw new System.Exception($"Thare is no free alements in pool of type {typeof(T)}");
        }
    }
}