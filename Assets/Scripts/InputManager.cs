using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    [SerializeField] private Vector3 mouseWorldPos;

    public static InputManager Instance { get => instance; }
    
    public Vector3 MouseWorldPos { get => mouseWorldPos; }

    private void Awake()
    {
        if(InputManager.instance != null)
        {
            Debug.LogError("Only 1 InputManager allow to exist ");
        }
        InputManager.instance = this;
    }
    void FixedUpdate()
    {
       GetMousePos();
    }
    protected virtual void GetMousePos()
    {
        mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
