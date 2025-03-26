using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseExtensions : MonoBehaviour
{

    public List<GameObject> objectsList;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetRandomFromList();
        }
    }

    public void GetRandomFromList()
    {
        if(objectsList.Count == 0)
        {
            return;
        }
        var obj = objectsList.GetRandom();
        GameObject instance = Instantiate(obj);
        Destroy(instance, 3f);
        
       
    }

   
  

}
