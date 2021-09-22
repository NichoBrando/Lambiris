using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject camera;
    [SerializeField]
    private float endPoint;
    [SerializeField]
    private float startPoint;

    private bool isWaitingForTransition = false;

    void ChangePosition(float newPosition)
    {
        camera.transform.position = new Vector3(newPosition, 0, -10);
    }

    void FixedUpdate()
    {
        if(camera.transform.position.x >= endPoint) {
            if (!isWaitingForTransition) StartCoroutine(RestartPosition());
            return;
        }
        ChangePosition(camera.transform.position.x + 1 * Time.deltaTime);
    }

    IEnumerator RestartPosition()
    {
        isWaitingForTransition = true;
        yield return new WaitForSeconds(1.5f);
        ChangePosition(startPoint);
        isWaitingForTransition = false;
    }
}
