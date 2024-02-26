using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAutomaticMovements : MonoBehaviour
{
    GameObject target;

    float travelDuration = 60f;

    Vector3 min = new Vector3(-20f, 0f, -10f);
    Vector3 max = new Vector3(20f, 0f, -10f);

    // Start is called before the first frame update
    void Start()
    {
        target = new GameObject("Camera Target");

        target.transform.position = min;
        transform.position = min;

        StartCoroutine(Travel(min, max));
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime);
    }

    IEnumerator Travel(Vector3 startPosition, Vector3 endPosition)
    {
        float elapsedTime = 0f;

        while (elapsedTime < travelDuration)
        {
            target.transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / travelDuration);
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        StartCoroutine(Travel(endPosition, startPosition));
    }
}