using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__speed_dbghanoi__speed_dbghanoi_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__speed_dbghanoi__speed_dbghanoi_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_speed_dbghanoi\\_speed_dbghanoi.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
