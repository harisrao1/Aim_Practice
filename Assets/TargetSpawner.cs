﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Set in Insepector")]
    public GameObject targetPrefab;
    public float delay;
    public GameObject BackWall;
    public int MaxTargetsOnScreen;
    private List<GameObject> targetList;

    private float WallX = 14f;
    private float WallY = 8f;
    

    private float z = -0.5f;
    void Start()
    {
        targetList = new List<GameObject>();
        Invoke("SpawnTarget", 2f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        
    }

    public void SpawnTarget()
    {
        GameObject target = Instantiate<GameObject>(targetPrefab);
        Vector3 pos = Vector3.zero;
        pos.z = z;
        pos.x = getXPos(target);
        pos.y = getYPos(target);
        //Debug.Log("POS :" + pos);
        target.transform.position = pos;
        targetList.Add(target);
        if (targetList.Count >= MaxTargetsOnScreen)
        {
            SceneManager.LoadScene("Scene_0");
        }
        else
        {
            Invoke("SpawnTarget", delay);
        }
    }

    public float getXPos(GameObject target)
    {
        //Debug.Log("XXXXX:  " + Random.Range(BackWall.transform.position.x - (WallX / 2) + (target.GetComponent<SphereCollider>().radius * 2), BackWall.transform.position.x + (WallX / 2) - (target.GetComponent<SphereCollider>().radius * 2)));
        return Random.Range(BackWall.transform.position.x-(WallX/2)+(target.GetComponent<SphereCollider>().radius*2), BackWall.transform.position.x+(WallX/2) - (target.GetComponent<SphereCollider>().radius * 2));
    }
    public float getYPos(GameObject target)
    {
        //Debug.Log("YYYYY:   " + Random.Range(BackWall.transform.position.y - (WallY / 2) + (target.GetComponent<SphereCollider>().radius * 2), BackWall.transform.position.y + (WallY / 2) - (target.GetComponent<SphereCollider>().radius * 2)));
        return Random.Range(BackWall.transform.position.y-(WallY/2)+(target.GetComponent<SphereCollider>().radius*2), BackWall.transform.position.y+(WallY/2) - (target.GetComponent<SphereCollider>().radius *2));
    }
}
