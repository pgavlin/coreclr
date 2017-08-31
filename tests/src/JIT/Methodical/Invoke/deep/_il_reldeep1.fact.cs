using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_deep__il_reldeep1__il_reldeep1_
    {
        [Fact]
        public void _Invoke_deep__il_reldeep1__il_reldeep1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\deep\\_il_reldeep1\\_il_reldeep1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
