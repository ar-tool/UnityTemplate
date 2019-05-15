using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using System;
/**
 *Copyright(C) 2019 by hiscene
 *All rights reserved.
 *FileName:     SimpleTests.cs
 *Author:       yic
 *UnityVersion：2018.3.9f1
 *Date:         2019-05-13
 *Description:   
*/

[TestFixture]
public class SimpleTests
{
    [Test]
    public void TestForSimple()
    {

        Methods methods = new Methods();

        if( methods.Add() != 7)
        {
            throw new Exception("测试失败");
        }
    }


    public class Methods
    {
        private int a = 1;
        private int b = 6;

        public int Add()
        {

            return a + b;
        }

        public int Sub()
        {

            return a - b;
        }
    }
}
