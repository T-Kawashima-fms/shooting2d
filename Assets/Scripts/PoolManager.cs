using UnityEngine;
using UnityEngine.Pool;
public class PoolManager : MonoBehaviour
{
    ObjectPool<GameObject> pool;
    public GameObject Prefab { get; private set; }
    void Start()
    {
        pool = new ObjectPool<GameObject>
        (
            createFunc: CreatePooledObject, 
            actionOnGet: GetFromPool, 
            actionOnRelease: ReleaseToPool, 
            actionOnDestroy: DestroyPooledObject
        );
    }
    private GameObject CreatePooledObject()
    {
        return Instantiate(Prefab);
    }
    private void GetFromPool(GameObject obj)
    {
        obj.SetActive(true);
    }
    private void ReleaseToPool(GameObject obj)
    {
        obj.SetActive(false);
    }
    private void DestroyPooledObject(GameObject obj)
    {
        Destroy(obj);
    }

    public GameObject GetGameObject(GameObject prefab)
    {
        Prefab = prefab;
        GameObject obj = pool.Get();
        return obj;
    }
    public void ReleaseGameObject(GameObject obj)
    {
        pool.Release(obj);
    }
}