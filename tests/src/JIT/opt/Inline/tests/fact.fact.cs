using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_fact_fact_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_fact_fact_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\fact\\fact.cmd");
        }
    }
}
