using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //���ϸ����� ����
    Animator animator;
    //�÷��̾� �̵� �ӵ� (����)
    float playerSpeed = 3.0f;
    public float playerHP = 100;

    public static PlayerMove pm;
    void Awake()
    {
        if(pm == null)
        {
            pm = this;
        }
    }


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
        
        //�¿���� �� �ִϸ��̼�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);   //�¿����
            animator.SetBool("Walk", true);   //�ٴ� �ִϸ��̼� ����
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.localEulerAngles = new Vector3(0, 180, 0);   //�¿����
            animator.SetBool("Walk", true);   //�ٴ� �ִϸ��̼� ����
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("Walk", true);   //�ٴ� �ִϸ��̼� ����
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("Walk", true);   //�ٴ� �ִϸ��̼� ����
        }
        else
        {
            animator.SetBool("Walk", false);   //�ٴ� �ִϸ��̼� ����
        }
        
    }
}
