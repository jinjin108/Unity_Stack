using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public void Start()
    {
        MyStack stack = new MyStack(3);

        stack.Push(4);
        stack.Push(1);
        stack.Push(10);


        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());


    }

}
