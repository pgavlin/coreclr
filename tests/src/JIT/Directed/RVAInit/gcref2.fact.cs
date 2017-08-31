using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _RVAInit_gcref2_gcref2_
    {
        [OuterLoop]
        [Fact]
        public void _RVAInit_gcref2_gcref2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\gcref2\\gcref2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
