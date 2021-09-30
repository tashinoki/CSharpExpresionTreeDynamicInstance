using System;
using System.ComponentModel;
using System.Dynamic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace CSharpExpression
{
    class Program
    {
        Expression<Func<int, int>> exp = x => x + 5;

        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Sample>();
        }
    }

    public class Sample
    {
        [Benchmark]
        public void Create()
        {
            var job = JobCreater<Job>.Create();
        }

        [Benchmark]
        public void CreateInstance()
        {
            var job = JobCreaterExpression<Job>.Create();
        }
    }

    public static class JobCreater<T> where T : new()
    {
        public static T Create()
        {
            return new T();
        }
    }

    public static class JobCreaterExpression<T>
    {
        public static Func<T> Create => CreateInstance();

        private static Func<T> CreateInstance()
        {
            var newExp = Expression.New(typeof(T));
            return Expression.Lambda<Func<T>>(newExp).Compile();
        }
    }

    public class Job
    {

    }
}
