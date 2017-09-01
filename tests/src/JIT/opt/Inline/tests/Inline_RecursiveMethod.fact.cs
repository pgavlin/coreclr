using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_Inline_RecursiveMethod_Inline_RecursiveMethod_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_Inline_RecursiveMethod_Inline_RecursiveMethod_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\Inline_RecursiveMethod\\Inline_RecursiveMethod.cmd");
        }
    }
}
