using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Target {
    public string name;
    public GameObject prefab;
    public float interval;
    public float timer;
}

public class TargetManager : MonoBehaviour
{
    public PoolManager poolManager;

    // Prefabs
    public Target[] targets = new Target[4];

    private float destroyWaitTime = 10;

    public bool isPlaying;

    void Start()
    {
        isPlaying = false;
    }

    void Update()
    {
        if (isPlaying)
        {
            for (int i = 0; i < targets.Length; i++)
            {
                targets[i].interval = ParameterManager.targetsParameter[i].interval;

                targets[i].timer += Time.deltaTime;
                if (targets[i].timer > targets[i].interval)
                {
                    Destroyer destroyer;
                    destroyer = poolManager.GetGameObject(targets[i].prefab).GetComponent<Destroyer>();
                    destroyer.PoolManager = poolManager;
                    if (destroyer != null) { destroyer.StartDestroyTimer(destroyWaitTime); }
                    targets[i].timer = 0;
                }
            }
        }
        
    }

}

