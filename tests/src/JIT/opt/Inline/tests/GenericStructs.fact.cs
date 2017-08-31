using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_GenericStructs_GenericStructs_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_GenericStructs_GenericStructs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\GenericStructs\\GenericStructs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
