using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_01 : MonoBehaviour
{

    public int test_int;     //����Ÿ���� �����Ҷ�, 
    public float test_float;
    public bool test_bool;
    public string test_string;



    public int[] test_array_int = new int[2];      //intŸ���� ���� ���� ���� ���

    // Start is called before the first frame update
    void Start()
    {



        //test_array_int[0] = 1;           //�迭 0��° �ε����� 1�� ���� �Ҵ�
        //test_int = test_array_int[0];    //�迭 0��° �ε����� �ִ� 1�� ���� test_int�� �Ҵ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
