using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _AsgAnd1_AsgAnd1_
    {
        [OuterLoop]
        [Fact]
        public void _AsgAnd1_AsgAnd1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\AsgAnd1\\AsgAnd1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
