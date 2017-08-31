using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _AsgSub1_AsgSub1_
    {
        [OuterLoop]
        [Fact]
        public void _AsgSub1_AsgSub1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\AsgSub1\\AsgSub1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
