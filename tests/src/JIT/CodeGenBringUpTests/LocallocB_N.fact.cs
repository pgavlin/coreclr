using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _LocallocB_N_LocallocB_N_
    {
        [OuterLoop]
        [Fact]
        public void _LocallocB_N_LocallocB_N_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocB_N\\LocallocB_N.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
