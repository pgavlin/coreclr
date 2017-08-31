using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__dbghanoi__dbghanoi_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__dbghanoi__dbghanoi_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_dbghanoi\\_dbghanoi.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
