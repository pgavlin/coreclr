using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_reltest_2a__il_reltest_2a_
    {
        [Fact]
        public void _tailcall__il_reltest_2a__il_reltest_2a_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_reltest_2a\\_il_reltest_2a.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
