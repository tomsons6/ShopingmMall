using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    float movingspeed = 5f;
    Camera Cam;
    // Start is called before the first frame update
    void Start()
    {
        Cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 CursorPos = Input.mousePosition;
            Vector3 DisplayMouse = Display.RelativeMouseAt(Input.mousePosition);
            foreach(Display disp in Display.displays)
            {
                Debug.Log(disp);
            }

            if(Cam.pixelRect.Contains(Input.mousePosition))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Debug.DrawRay(Input.mousePosition, Vector3.forward, color: Color.green);
                if (Physics.Raycast(ray, out hit, 1000.0f))
                {
                    if (hit.transform.tag == "Teleport")
                    {
                        StartCoroutine(MoveCamera(hit.transform));
                    }

                }
            }

        }
        if(Input.touchCount >0 && Cam.pixelRect.Contains(Input.GetTouch(0).rawPosition))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).rawPosition);
            Debug.DrawRay(Input.mousePosition, Vector3.forward, color: Color.green);
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.transform.tag == "Teleport")
                {
                    StartCoroutine(MoveCamera(hit.transform));
                }

            }
        }
    }

    IEnumerator MoveCamera(Transform clickedObject)
    {
        Vector3 CameraEndPosition = new Vector3(clickedObject.position.x, transform.position.y, clickedObject.position.z);
        float t = 0f;
        while (t <= movingspeed)
        {
            t += Time.deltaTime;
            Vector3 CurrentPosition = Vector3.Lerp(transform.position, CameraEndPosition, (t/movingspeed));
            transform.position = CurrentPosition;
            if(transform.position == CameraEndPosition)
            {
                break;
            }
            yield return null;
        }
    }
}
