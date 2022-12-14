using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStack
{
    
    public int Count;//지금 스택에 데이터가 몇개가 들어가 있는지 체크
    public int[] stack;
    public MyStack(int size) 
    {
        stack = new int[size];//size 크기만큼 배열을 생성 , int[]생성 
    }
    public void Push(int data)
    {        
        if ( stack.Length < Count)
        {
            Debug.Log("stack overflow");//스택의 사이즈를 초과해서 push를 하려고하면 stack overflow
            int[] newStack = new int[stack.Length * 2];//새로운 newStack에다가 원래 stack의 값들을 넣어주고 stack를 newStack로 갈아치우면된다
            for (int i = 0; i <= stack.Length; i++)
            {
                newStack[i] = stack[i];
            }

            stack = newStack;
            stack[Count] = data;
            Count++;

        }
        else
        {

            stack[Count] = data;
            Count++;
        }

    }
    public int Pop()
    {
        if (Count <= 0)
        {
            Debug.Log("Stack is Empty");//스택에 데이터가 없는데 Pop를 하려고 하면 에러 - Stack is Empty
            return 0;
        }
        else
        {
            return stack[--Count];

        }

    }
    public void Clear()
    {
        
    }


}
