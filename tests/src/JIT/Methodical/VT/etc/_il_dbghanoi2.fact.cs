using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__il_dbghanoi2__il_dbghanoi2_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__il_dbghanoi2__il_dbghanoi2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_il_dbghanoi2\\_il_dbghanoi2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
