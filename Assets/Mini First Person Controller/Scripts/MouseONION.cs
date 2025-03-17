using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseONION : MonoBehaviour
{
    [SerializeField]
    private float mouseSensivity = 500;
    private float headHorizontal;
    private float headVertical;
    [SerializeField]
    private float lookLock = 50;
    [SerializeField]
    private GameObject head;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseLook();
    }
    void MouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;

        // для вращения головой  
        headHorizontal += mouseX;
        headVertical += mouseY;

        // ограничение вертикального обзора
        headVertical = Mathf.Clamp(headVertical, -lookLock, lookLock);
        head.transform.eulerAngles = new Vector3(-headVertical, head.transform.eulerAngles.y, 0);

        // поворот игрока мышкой
        transform.eulerAngles = new Vector3(0, headHorizontal, 0);

        // Антитряска
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
