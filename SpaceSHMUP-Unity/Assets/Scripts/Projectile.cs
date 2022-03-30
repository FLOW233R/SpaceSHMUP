/**** 
 * Created by: Siyu Yang
 * Date Created: March 30, 2022
 * 
 * Last Edited by: Siyu Yang
 * Last Edited: March 30, 2022
 * 
 * Description: Projectile behavior
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private BoundsCheck bndCheck;


    // Start is called before the first frame update
    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }//end awake

    // Update is called once per frame
    void Update()
    {
        if(bndCheck.offUp)
        {
            Destroy(gameObject);
        }
    }//end uodate
}
