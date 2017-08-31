using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Convert_implicitConv_implicitConv_
    {
        [OuterLoop]
        [Fact]
        public void _Convert_implicitConv_implicitConv_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Convert\\implicitConv\\implicitConv.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
