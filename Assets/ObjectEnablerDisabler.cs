using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEnablerDisabler : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void EnableObject(GameObject targetObject)
    {
        if (targetObject != null)
        {
            Debug.Log("Enabled object" + targetObject);
            targetObject.SetActive(true);
        }
    }

    public void DisableObject(GameObject targetObject)
    {
        if (targetObject != null)
        {
            targetObject.SetActive(false);
            Debug.Log("Disabled object" + targetObject);
        }

    }

    
}
