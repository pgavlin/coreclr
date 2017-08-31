using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_StructAsParam_Method_StructAsParam_Method_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_StructAsParam_Method_StructAsParam_Method_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\StructAsParam_Method\\StructAsParam_Method.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
