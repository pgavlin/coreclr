using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _RVAInit_gcref1_gcref1_
    {
        [OuterLoop]
        [Fact]
        public void _RVAInit_gcref1_gcref1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\gcref1\\gcref1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
