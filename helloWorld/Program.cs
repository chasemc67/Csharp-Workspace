﻿using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node<int> myNode = new Node<int>(1, 2);
            Console.WriteLine(myNode.leftHand);
            myNode.leftHand = 10;
            Console.WriteLine(myNode.leftHand);
            Console.WriteLine(myNode.rightHand);

            var parent = new ParentClass("parent");
            var child = new ChildClass("child");

            Console.WriteLine(child.name);
            Console.WriteLine(child.health);
        }
    }
}
