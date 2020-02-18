using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Set in Insepector")]
    public GameObject targetPrefab;
    public float delay;
    public GameObject BackWall;

    public float z = 0.5f;
    void Start()
    {
        Invoke("SpawnTarget", 2f);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SpawnTarget()
    {
        GameObject target = Instantiate<GameObject>(targetPrefab);
        Vector3 pos = Vector2.zero;
        pos.z = z;
        pos.x = getXPos();
        pos.y = getYPos();
        target.transform.position = pos;
        Invoke("SpawnTarget", delay);
    }

    public float getXPos()
    {
        return 0;
    }
    public float getYPos()
    {
        return 0;
    }
}
