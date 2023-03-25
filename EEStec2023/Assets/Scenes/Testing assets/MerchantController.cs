using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantController : MonoBehaviour
{
    //[SerializeField]
    public Vector3 rotationCenter;


    [SerializeField]
    float rotationRadius = 2f, angularSpeed = 2f;

    float posX, posY, angle = 0f;

    private void Awake()
    {
        rotationCenter = transform.position;
    }


    void Update()
    {
        posX = rotationCenter.x + Mathf.Cos(angle) * rotationRadius;
        posY = rotationCenter.y + Mathf.Sin(angle) * rotationRadius;
        transform.position = new Vector2(posX, posY);
        angle = angle + Time.deltaTime * angularSpeed;

        if (angle > 360f)
            angle = 0f;
    }

    private Vector3 initialPos;




 
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame

}
