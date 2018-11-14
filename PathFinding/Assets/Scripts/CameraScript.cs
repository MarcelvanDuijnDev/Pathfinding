using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameHandler m_GameHandler;
    [SerializeField] private float m_CameraSpeed;

    private Camera camera;

    void Start()
    {
        camera = this.gameObject.GetComponent<Camera>();
    }

    void Update ()
    {
        //Camera Movement
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * m_CameraSpeed * Time.deltaTime,
            0,
            Input.GetAxis("Vertical") * m_CameraSpeed * Time.deltaTime);
        transform.Translate(movement, Space.World);

        //Select Object
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                m_GameHandler.Selected_GridObject(hit.transform.gameObject);
            }
        }
    }
}
