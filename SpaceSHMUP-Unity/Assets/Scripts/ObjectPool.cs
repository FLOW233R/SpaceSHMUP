/**** 
 * Created by: Siyu Yang
 * Date Created: March 30, 2022
 * 
 * Last Edited by: Siyu Yang
 * Last Edited: Apirl 02, 2022
 * 
 * Description: pool 
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    /*** VARIABLES ***/

    #region POOL Singleton
    static public ObjectPool POOL;

    void CheckPOOLIsInScene()
    {
        if(POOL == null)
        {
            POOL = this;
        }
        else
        {
            Debug.LogError("POOL.Awake() - Attempted to assing a seond ObjectPook.POOL");
        }
    }
    #endregion 

    private Queue<GameObject> projectiles = new Queue<GameObject>();//queue of game objects to be added to pool

    [Header("Pool Settings")]
    public GameObject projectilPrefab;
    public int poolStartSize = 5;

    /***METHODS***/
    private void Awake()
    {
        CheckPOOLIsInScene();
    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < poolStartSize; i++)
        {
            GameObject gObject = Instantiate(projectilPrefab);
            projectiles.Enqueue(gObject);//add to queue
            gObject.SetActive(false);//aisable project in scene
        }
    }//end start


    public GameObject GetObject()
    {
        if(projectiles .Count > 0)
        {
            GameObject gObject = projectiles.Dequeue();
            gObject.SetActive(true);
            return gObject;
        }
        else
        {
            Debug.LogWarning("Out of projectiles, Reloading...");
            return null;
        }
    }//end GetObejct()

    public void ReturnObject(GameObject gObject)
    {
        projectiles.Enqueue(gObject);
        gObject.SetActive(false);
    }



}
