using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMoving : MonoBehaviour
{
    public GameObject target_Object;
    Rigidbody2D rid;
    Animator animatorPlayer;
    public float monsterSpeed;
    public float monsterHP;
    CapsuleCollider capsuleCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        rid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var target_dirction = target_Object.transform.position - transform.position;
        if (Vector3.Distance(target_Object.transform.position, transform.position) > 0.7f)
        {
            rid.MovePosition(transform.position + target_dirction.normalized * monsterSpeed);
        }

        if(monsterHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerMove.pm.playerHP -= 10;
            Debug.Log(PlayerMove.pm.playerHP);
        }
    }
}
