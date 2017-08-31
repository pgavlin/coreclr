using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall_v4_tailcall_AV_tailcall_AV_
    {
        [Fact]
        public void _tailcall_v4_tailcall_AV_tailcall_AV_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall_v4\\tailcall_AV\\tailcall_AV.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
