using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
    public GameObject Tilt;
    Vector2 i_movement;
    float moveSpeed = 10f;
    bool Moving = false;
    Vector2 notMoving;
    public float tiltspeed = 10;


    // Start is called before the first frame update
    void Start()
    {
        notMoving.x = 0;
        notMoving.y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        /*
        if ((i_movement == notMoving) && (Tilt.transform.rotation.x >= 0))
        {
            Tilt.transform.Rotate(+15 * tiltspeed* Time.deltaTime, 0, 0);
            Debug.Log("Notmoving");
        }
        else if ((i_movement != notMoving)&&(Tilt.transform.rotation.x >= -15))
        {
            Tilt.transform.Rotate(-15 * tiltspeed * Time.deltaTime, 0, 0);
            Debug.Log("Moving");
        }
        */

        /*if (true) { }
            Tilt.transform.eulerAngles = new Vector3(
            Tilt.transform.eulerAngles.x = 30,
            Tilt.transform.eulerAngles.y,
            Tilt.transform.eulerAngles.z
            );*/
    }

        private void Move()
        {

            Vector3 movement = new Vector3(i_movement.x, 0, i_movement.y) * moveSpeed * Time.deltaTime;
            transform.Translate(movement);

            Vector2 StickVectorTemp = Gamepad.current.leftStick.ReadValue();
            float StickValue = Mathf.Abs(StickVectorTemp.x) + Mathf.Abs(StickVectorTemp.y);


            if ((StickValue > 0) && (Tilt.transform.rotation.x > -15))
            {
                Tilt.transform.Rotate(-15 * tiltspeed * Time.deltaTime, 0, 0);

            }
            else if (Tilt.transform.rotation.x < 0)
            {
                Tilt.transform.Rotate(+15 * tiltspeed * Time.deltaTime, 0, 0);
            }

        }

        private void OnMove(InputValue value)
        {
            i_movement = value.Get<Vector2>();
            Debug.Log(value);
        }
        private void OnPressA()
        {
            Debug.Log("A!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        }
        private void OnPressY()
        {
            Debug.Log("Y!");
        }
        private void OnPressX()
        {
            Debug.Log("X!");
        }
        private void OnPressB()
        {
            Debug.Log("B!");
        }
    } 
