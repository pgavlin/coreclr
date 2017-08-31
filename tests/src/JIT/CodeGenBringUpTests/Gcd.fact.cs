using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _Gcd_Gcd_
    {
        [OuterLoop]
        [Fact]
        public void _Gcd_Gcd_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Gcd\\Gcd.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
