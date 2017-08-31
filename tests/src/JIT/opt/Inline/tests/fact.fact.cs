using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_fact_fact_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_fact_fact_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\fact\\fact.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
