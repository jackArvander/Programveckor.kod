using UnityEngine;
using System.Collections;

public class WaterDrop : MonoBehaviour
{

    public GameObject objectToDisable;
    public float timer = 5f;

    void Start()
    {
        StartCoroutine(EnableAfterTime());
    }

    IEnumerator EnableAfterTime()
    {
        while (true)
        {
            objectToDisable.SetActive(false);
            yield return new WaitForSeconds(timer);
            objectToDisable.SetActive(true);
            yield return new WaitForSeconds(timer);
        }
    }

}
