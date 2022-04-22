using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float smoothSpeed = 0.125f;
    public GameObject player;
    public Vector3 offset;
    public Vector3 minCameraPos;
    public Vector3 maxCameraPos;

    private Vector3 lerpPos;
    private Vector3 currentPos;
    private Camera _camera;
    private Vector3[] cameraCorners;
    private Rect cameraRect;

    // Start is called before the first frame update
    void Start()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        currentPos = player.transform.position;

        _camera = GetComponent<Camera>();
        cameraCorners = new Vector3[4];

        _camera.CalculateFrustumCorners(new Rect(0, 0, 1, 1), _camera.farClipPlane, Camera.MonoOrStereoscopicEye.Mono, cameraCorners);
        float minX = 0f, minY = 0f;
        float maxX = 0f, maxY = 0f;
        for (int i = 0; i < 4; i++)
        {
            cameraCorners[i] = _camera.transform.TransformVector(cameraCorners[i]);

            if(cameraCorners[i].x < minX)
            {
                minX = cameraCorners[i].x;
            } else if (cameraCorners[i].x > maxX)
            {
                maxX = cameraCorners[i].x;
            }
            if (cameraCorners[i].y < minY)
            {
                minY = cameraCorners[i].y;
            } else if (cameraCorners[i].y > maxY)
            {
                maxY = cameraCorners[i].y;
            }
        }

        cameraRect = new Rect(minX, minY, Mathf.Abs(minX - maxX), Mathf.Abs(minY - maxY));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float lerpPercent = 1f - Mathf.Exp((Mathf.Log(1f - 0.99f) / smoothSpeed) * Time.deltaTime);
        currentPos = player.transform.position + offset;
        lerpPos = Vector3.Lerp(currentPos, transform.position, lerpPercent);

        transform.position = lerpPos;
        ClampCameraPosition();
        //transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }

    private void ClampCameraPosition()
    {
        if(transform.position.x  + cameraRect.xMin < minCameraPos.x)
        {
            transform.position = new Vector3(minCameraPos.x - cameraRect.xMin, transform.position.y, transform.position.z);
        } else if (transform.position.x + cameraRect.xMax > maxCameraPos.x)
        {
            transform.position = new Vector3(maxCameraPos.x - cameraRect.xMax, transform.position.y, transform.position.z);
        }
        if (transform.position.y + cameraRect.yMin < maxCameraPos.y)
        {
            transform.position = new Vector3(transform.position.x, maxCameraPos.y - cameraRect.yMin, transform.position.z);
        }
        else if (transform.position.y + cameraRect.yMax > minCameraPos.y)
        {
            transform.position = new Vector3(transform.position.x, minCameraPos.y - cameraRect.yMax, transform.position.z);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(minCameraPos, new Vector3(maxCameraPos.x, minCameraPos.y, maxCameraPos.z));
        Gizmos.DrawLine(new Vector3(maxCameraPos.x, minCameraPos.y, maxCameraPos.z), maxCameraPos);
        Gizmos.DrawLine(maxCameraPos, new Vector3(minCameraPos.x, maxCameraPos.y, maxCameraPos.z));
        Gizmos.DrawLine(new Vector3(minCameraPos.x, maxCameraPos.y, maxCameraPos.z), minCameraPos);

    }
}
