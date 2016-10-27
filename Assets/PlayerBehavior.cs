using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed = 0.1f;

    void Start()
    {

    }

    public void FixedUpdate()
    {
        if (gameObject.tag == "PlayerOne")
        {
            float verticalSpeed = Input.GetAxisRaw("VerticalJoy");
            float horizontalSpeed = Input.GetAxisRaw("HorizontalJoy");
            transform.Translate(horizontalSpeed * moveSpeed, verticalSpeed  * moveSpeed, 0);
        }

        if (gameObject.tag == "PlayerTwo")
        {
            {
                float verticalSpeed = Input.GetAxisRaw("Vertical");
                float horizontalSpeed = Input.GetAxisRaw("Horizontal");
                transform.Translate(horizontalSpeed * moveSpeed, verticalSpeed * moveSpeed, 0);
            }
        }
    }
}


//void Update()
//{
//    if (gameObject.tag == "PlayerOne")
//    {
//   //     if (Input.GetButton("PlayerOneHorizontal"))
//            transform.Translate(0, moveSpeed, 0);
//        //else if (Input.GetButton("PlayerOneDown"))
//        //    transform.Translate(0, -moveSpeed, 0);

//        //if (Input.GetKey(KeyCode.W))
//        //    transform.Translate(0, moveSpeed, 0);
//        //else if (Input.GetKey(KeyCode.S))
//        //    transform.Translate(0, -moveSpeed, 0);
//    }

//    if (gameObject.tag == "PlayerTwo")
//    {
//        if (Input.GetButton("PlayerTwoUp"))
//            transform.Translate(0, moveSpeed, 0);
//        else if (Input.GetButton("PlayerOneDown"))
//            transform.Translate(0, -moveSpeed, 0);


//        //if (Input.GetKey(KeyCode.UpArrow))
//        //    transform.Translate(0, moveSpeed, 0);
//        //else if (Input.GetKey(KeyCode.DownArrow))
//        //    transform.Translate(0, -moveSpeed, 0);
//    }
//}
