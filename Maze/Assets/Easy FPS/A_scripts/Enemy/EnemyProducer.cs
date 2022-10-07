using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;
using UnityEngine.SceneManagement;
public class EnemyProducer : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;

    [SerializeField] private DateTime lastUpdate;

    void Start()
    {
	    lastUpdate = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
	    if (DateTime.Now.Second - lastUpdate.Second >= 1)
	    {
		    var i = UnityEngine.Random.Range(0, this.enemies.Length);
		    Instantiate(enemies[i],
			    new Vector3(UnityEngine.Random.Range(-1, 0), 6, UnityEngine.Random.Range(-1, 0)),
			    Quaternion.identity);
		    lastUpdate = DateTime.Now;

            // if (this.enemies.Length<=1){
            //     SceneManager.LoadScene(2);
            // }
	    }
    }
}