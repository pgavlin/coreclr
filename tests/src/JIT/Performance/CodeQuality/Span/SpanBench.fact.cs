using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_Span_SpanBench_SpanBench_
    {
        [Fact]
        public void _CodeQuality_Span_SpanBench_SpanBench_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Span\\SpanBench\\SpanBench.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
