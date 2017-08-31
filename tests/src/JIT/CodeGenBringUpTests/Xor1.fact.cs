using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _Xor1_Xor1_
    {
        [OuterLoop]
        [Fact]
        public void _Xor1_Xor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Xor1\\Xor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
