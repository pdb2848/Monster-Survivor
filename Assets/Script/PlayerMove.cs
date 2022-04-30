using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //에니매이터 변수
    Animator animator;
    //플레이어 이동 속도 (미정)
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

    //플레이어 이동 함수
    void Walk()
    {
        float h = Input.GetAxis("Horizontal");      //좌우 이동
        transform.position += Vector3.right * h * playerSpeed * Time.deltaTime;

        float v = Input.GetAxis("Vertical");        //상하 이동
        transform.position += Vector3.up * v * playerSpeed * Time.deltaTime;
        
        //좌우반전 및 애니메이션
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);   //좌우반전
            animator.SetBool("Walk", true);   //뛰는 애니메이션 실행
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.localEulerAngles = new Vector3(0, 180, 0);   //좌우반전
            animator.SetBool("Walk", true);   //뛰는 애니메이션 실행
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("Walk", true);   //뛰는 애니메이션 실행
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("Walk", true);   //뛰는 애니메이션 실행
        }
        else
        {
            animator.SetBool("Walk", false);   //뛰는 애니메이션 종료
        }
        
    }
}
