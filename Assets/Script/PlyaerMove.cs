using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyaerMove : MonoBehaviour
{
    //���ϸ����� ����
    Animator animator;
    //�÷��̾� �̵� �ӵ� (����)
    float playerSpeed = 3.0f;
    


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Walk();
    }

    //�÷��̾� �̵� �Լ�
    void Walk()
    {
        float h = Input.GetAxis("Horizontal");      //�¿� �̵�
        transform.position += Vector3.right * h * playerSpeed * Time.deltaTime;

        float v = Input.GetAxis("Vertical");        //���� �̵�
        transform.position += Vector3.up * v * playerSpeed * Time.deltaTime;
        



        //2
        /*
        //�¿��̵�
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.position += Vector3.left * playerSpeed * Time.deltaTime;
            this.gameObject.transform.localEulerAngles = new Vector3(0, 180, 0);   //�¿����
            animator.SetBool("Walk", true);   //�ٴ� �ִϸ��̼� ����
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * playerSpeed * Time.deltaTime;
            this.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);   //�¿����
            animator.SetBool("Walk", true);   //�ٴ� �ִϸ��̼� ����
        }

        else if (!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Walk", false);   //�ٴ� �ִϸ��̼� ����
        }
        */
    }
}
