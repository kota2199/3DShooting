using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour {

    public GameObject enemy;
    // Use this for initialization
    void Start () {
        StartCoroutine("shot");
	}
	
	// Update is called once per frame
	void Update () {
        //Instantiate(enemy, transform.position, transform.rotation);
	}
    
    /// <summary>
    /// 弾を2秒に１回生成
    /// </summary>
    /// <returns></returns>
    private IEnumerator shot()
    {
        while (true)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            yield return new WaitForSeconds(2);
        }
    }
}
