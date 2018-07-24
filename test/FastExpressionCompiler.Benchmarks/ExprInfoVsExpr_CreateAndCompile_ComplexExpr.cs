﻿using BenchmarkDotNet.Attributes;
using FastExpressionCompiler.UnitTests;

namespace FastExpressionCompiler.Benchmarks
{
    [MemoryDiagnoser]
    public class ExprInfoVsExpr_CreateAndCompile_ComplexExpr
    {
        [Benchmark]
        public object CreateExpression_and_Compile()
        {
            return ExpressionInfoTests.CreateComplexExpression().Compile();
        }

        [Benchmark]
        public object CreateExpression_and_CompileFast()
        {
            return ExpressionInfoTests.CreateComplexExpression().CompileFast();
        }

        [Benchmark(Baseline = true)]
        public object CreateExpressionInfo_and_CompileFast()
        {
            return ExpressionInfoTests.CreateComplexExpressionInfo().CompileFast();
        }
    }

    [MemoryDiagnoser]
    public class ExprInfoVsExpr_Create_ComplexExpr
    {
        [Benchmark]
        public object CreateExpression()
        {
            return ExpressionInfoTests.CreateComplexExpression();
        }

        [Benchmark(Baseline = true)]
        public object CreateExpressionInfo()
        {
            return ExpressionInfoTests.CreateComplexExpressionInfo();
        }
    }
}
