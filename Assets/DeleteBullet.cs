using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBullet : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(waiter());
    }
    IEnumerator waiter()
    {  
        yield return new WaitForSeconds(10);
        Object.Destroy(this.gameObject);
    }
}
