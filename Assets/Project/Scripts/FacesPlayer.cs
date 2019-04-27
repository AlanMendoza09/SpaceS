using UnityEngine;
using System.Collections;

public class FacesPlayer : MonoBehaviour {
    float speed = 3.0f;
    private void Update()
    {
        transform.Translate(Vector3.left*speed * Time.deltaTime);

    }
}
