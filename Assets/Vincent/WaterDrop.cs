using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{

    public GameObject objectToDisable;
    public float timer = 5f;

    void Start()
    {
        StartCoroutine(EnableAfterTime());
    }

    IEnumerator EnableAfterTime()
    {
        objectToDisable.SetActive(false);
        yield return new WaitForSeconds(timer);
        objectToDisable.SetActive(true);
    }
}
