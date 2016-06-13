using System;
using System.Collections.Generic;
using NBench;
using NBench.Tracing;
using Ploeh.AutoFixture;

namespace IntelliTestAndUnitTesting.NBench
{
    public class AlgorithmPerfSpecs
    {
        private Counter _counter;
        private List<string> _list;
        private Algorithm1 _algorithm;

        [PerfSetup]
        public void Setup(BenchmarkContext context)
        {
            _counter = context.GetCounter("TestCounter");

            var fixture = new Fixture();
            fixture.RepeatCount = 100;
            _list = fixture.Create<List<string>>();
            _algorithm = new Algorithm1();
        }

        [PerfBenchmark(RunMode = RunMode.Iterations,
            RunTimeMilliseconds = 5000, TestMode = TestMode.Test)]
        [CounterThroughputAssertion("TestCounter", MustBe.GreaterThan, 1000.0d)]
        public void Benchmark()
        {
            _algorithm.BubbleSort(_list);
            //_list.Sort();
            _counter.Increment();
        }

        [PerfCleanup]
        public void Cleanup()
        {
            // does nothing
        }
    }
}