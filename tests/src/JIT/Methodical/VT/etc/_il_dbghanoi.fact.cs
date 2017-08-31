using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__il_dbghanoi__il_dbghanoi_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__il_dbghanoi__il_dbghanoi_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_il_dbghanoi\\_il_dbghanoi.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
