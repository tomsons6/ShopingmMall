using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class RotateCamera : MonoBehaviour
{
    public float speed = 3.5f;
    float x;
    float y;

    Vector3 FirstPoint;
    Vector3 SecondPoint;
    float xAngle;
    float yAngle;
    float xAngleTemp;
    float yAngleTemp;
    [SerializeField]
    Camera Cam;

    LayerMask UiLayer = 1 << 5;

    void Start()
    {
        xAngle = 0;
        yAngle = 0;
        this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0);
        Cam = GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Cam.pixelRect.Contains(Input.mousePosition) && !EventSystem.current.IsPointerOverGameObject(-1))
        {

            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * speed, -Input.GetAxis("Mouse X") * speed, 0));
            x = transform.rotation.eulerAngles.x;
            y = transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Euler(x, y, 0);

        }
        if (Input.touchCount > 0 && Cam.pixelRect.Contains(Input.GetTouch(0).position))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).rawPosition);
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.transform.gameObject.layer != UiLayer)
                {
                    if (Input.GetTouch(0).phase == TouchPhase.Began)
                    {
                        FirstPoint = Input.GetTouch(0).position;
                        xAngleTemp = xAngle;
                        yAngleTemp = yAngle;
                    }
                    if (Input.GetTouch(0).phase == TouchPhase.Moved)
                    {
                        SecondPoint = Input.GetTouch(0).position;
                        xAngle = xAngleTemp + (SecondPoint.x - FirstPoint.x) * 180 / Screen.width;
                        yAngle = yAngleTemp + (SecondPoint.y - FirstPoint.y) * 90 / Screen.height;
                        this.transform.rotation = Quaternion.Euler(yAngle, xAngle, 0.0f);
                    }
                }
            }
            //if (Input.GetTouch(0).phase == TouchPhase.Canceled)
            //{
            //    yAngleTemp = 0;
            //    xAngleTemp = 0;

            //}
        }
    }

}
