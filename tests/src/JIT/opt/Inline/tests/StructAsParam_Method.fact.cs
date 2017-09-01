using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_StructAsParam_Method_StructAsParam_Method_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_StructAsParam_Method_StructAsParam_Method_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\StructAsParam_Method\\StructAsParam_Method.cmd");
        }
    }
}
