﻿using System;

namespace PostSharp.Samples.ResharperAnnotations
{
    interface IProgram
    {

        [JetBrains.Annotations.NotNull]
        string Foo([JetBrains.Annotations.NotNull] string bar);

        [JetBrains.Annotations.NotNull]
        string FooFoo { get; set; }
    }

    class Program : IProgram
    {
        static void Main(string[] args)
        {

            IProgram p = new Program();

            try
            {
                p.Foo(null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                p.Foo("");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                p.FooFoo = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                p.FooFoo = "";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string Foo(string bar)
        {
            return null;
        }

        public string FooFoo { get; set; }
    }

   

}
