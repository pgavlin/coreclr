using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _RVAInit_oddsize_oddsize_
    {
        [OuterLoop]
        [Fact]
        public void _RVAInit_oddsize_oddsize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\oddsize\\oddsize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
