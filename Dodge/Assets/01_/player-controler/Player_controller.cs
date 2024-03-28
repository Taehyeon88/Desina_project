using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public Rigidbody player_rigidbody;       //�̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;      //�̵��ӷ�
    int test;
    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� player_rigidbody�� �Ҵ�
        player_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xspeed = xInput * speed;
        float zspeed = zInput * speed;

        //Vector3 �ӵ��� (xspeed, 0, zspeed)�� ����
        Vector3 newVelocity = new Vector3 (xspeed, 0 , zspeed);
        //������ٵ� �ӵ��� newVelocity �Ҵ�
        player_rigidbody.velocity = newVelocity;


    }
    public void Die()
    {    //�ڽ��� ���ӿ�����Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
   
}