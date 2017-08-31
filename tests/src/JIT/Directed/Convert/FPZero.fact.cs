using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Convert_FPZero_FPZero_
    {
        [OuterLoop]
        [Fact]
        public void _Convert_FPZero_FPZero_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Convert\\FPZero\\FPZero.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
