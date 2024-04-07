using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour {

    public Transform followTarget;
    public float adjustSpeed;

    private void Update() {

        float vertical = Mathf.Lerp(transform.position.y, followTarget.position.y, adjustSpeed * Time.deltaTime);

        transform.position = new Vector3(followTarget.position.x, vertical, followTarget.position.z);
    }
}