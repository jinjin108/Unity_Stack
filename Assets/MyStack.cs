using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStack
{
    
    public int Count;//���� ���ÿ� �����Ͱ� ��� �� �ִ��� üũ
    public int[] stack;
    public MyStack(int size) 
    {
        stack = new int[size];//size ũ�⸸ŭ �迭�� ���� , int[]���� 
    }
    public void Push(int data)
    {        
        if ( stack.Length < Count)
        {
            Debug.Log("stack overflow");//������ ����� �ʰ��ؼ� push�� �Ϸ����ϸ� stack overflow
            int[] newStack = new int[stack.Length * 2];//���ο� newStack���ٰ� ���� stack�� ������ �־��ְ� stack�� newStack�� ����ġ���ȴ�
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
            Debug.Log("Stack is Empty");//���ÿ� �����Ͱ� ���µ� Pop�� �Ϸ��� �ϸ� ���� - Stack is Empty
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
