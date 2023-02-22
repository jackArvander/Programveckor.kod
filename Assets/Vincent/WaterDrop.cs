using UnityEngine;
using System.Collections;

// vatten saken på första nivån - vincent
public class WaterDrop : MonoBehaviour
{

    public GameObject objectToDisable;
    public float timer = 5f;

    void Start()
    {
        StartCoroutine(EnableAfterTime()); // startar en timer när man spelar
    }

    IEnumerator EnableAfterTime() // da timer
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
