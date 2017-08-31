using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _AsgAdd1_AsgAdd1_
    {
        [OuterLoop]
        [Fact]
        public void _AsgAdd1_AsgAdd1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\AsgAdd1\\AsgAdd1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
