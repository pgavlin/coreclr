using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__relvtret__relvtret_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__relvtret__relvtret_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_relvtret\\_relvtret.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
