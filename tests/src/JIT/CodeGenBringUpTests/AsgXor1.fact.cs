using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _AsgXor1_AsgXor1_
    {
        [OuterLoop]
        [Fact]
        public void _AsgXor1_AsgXor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\AsgXor1\\AsgXor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
