using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_deep__il_reldeep2__il_reldeep2_
    {
        [Fact]
        public void _Invoke_deep__il_reldeep2__il_reldeep2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\deep\\_il_reldeep2\\_il_reldeep2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
