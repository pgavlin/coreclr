using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall_v4_smallFrame_smallFrame_
    {
        [Fact]
        public void _tailcall_v4_smallFrame_smallFrame_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall_v4\\smallFrame\\smallFrame.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
