using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlongBezier : MonoBehaviour
{
    public Transform[] Routes;

    private Vector2 objectPosition;
    private int routeTogo;
    private float t;
    private float speed;
    private bool coroutineAllow;

    private void Start()
    {
        routeTogo = 0;
        t = 0f;
        speed = 0.5f;
        coroutineAllow = true;
    }

    private void Update()
    {
        if (coroutineAllow)
            StartCoroutine(GoToAlongTheCurve(routeTogo));
    }

    private IEnumerator GoToAlongTheCurve(int routNumber)
    {
        coroutineAllow = false;

        Vector2 point0 = Routes[routNumber].GetChild(0).position;
        Vector2 point1 = Routes[routNumber].GetChild(1).position;
        Vector2 point2 = Routes[routNumber].GetChild(2).position;
        Vector2 point3 = Routes[routNumber].GetChild(3).position;

        while (t < 1)
        {
            t += Time.deltaTime * speed;

            objectPosition = Mathf.Pow(1 - t, 3) * point0 +
                3 * Mathf.Pow(1 - t, 2) * t * point1 +
                3 * (1 - t) * Mathf.Pow(t, 2) * point2 +
                Mathf.Pow(t, 3) * point3;

            transform.position = objectPosition;
            yield return new WaitForEndOfFrame();
        }

        t = 0;
        routeTogo += 1;

        if (routeTogo > Routes.Length - 1)
            routeTogo = 0;

        coroutineAllow = true;
    }
}
