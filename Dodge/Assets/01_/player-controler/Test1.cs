using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    int test_int;
    float test_float;
    string test_string;
    bool test_bool;

    /*public int test_int2;
    public int test_int3;
    public int test_int4;*/

    public int test_bool1;
    public int test_bool2;

    public bool test_while;
    private void Start()
    {
       /* for ( int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }*/






        //비교연산자는 >,<, ==, <=, >=, !=
        //논리연산자
        //&&그리고를 뜻함
        //또는
        //! 아니다
         

        //test_method(test_int2, test_int3);
        //test_int4 = test_method2(test_int2, test_int3);


    }

    private void Update()
    {
        while (test_bool1 < 100)
        {
            Debug.Log(test_bool1++);
          
         
        }





/*
        if (Input.GetKeyDown(KeyCode.Space))
            if (test_bool1 < test_bool2)
            {
                Debug.Log("참이다");
            }
            else if (test_bool1 == test_bool2)
            {
                Debug.Log("참이다");
            }
            else
            {
                Debug.Log("모두 거짓이다");
            }*/

    }
    /*void test_method(int a, int b)
    {
        Debug.Log(a + b);
    }

    int test_method2(int a, int b)
    {
        return a + b;
    }*/
}