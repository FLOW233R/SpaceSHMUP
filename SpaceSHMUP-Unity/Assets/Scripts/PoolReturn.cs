/**** 
 * Created by: Siyu Yang
 * Date Created: April 06, 2022
 * 
 * Last Edited by: Siyu Yang
 * Last Edited: April 06, 2022
 * 
 * Description: Hero ship controller
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{

    private ObjectPool pool;


    // Start is called before the first frame update
    void Start()
    {
        pool = ObjectPool.POOL;
    }

    private void OnDisable()
    {
        if (pool != null)
        {
            pool.ReturnObject(this.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
