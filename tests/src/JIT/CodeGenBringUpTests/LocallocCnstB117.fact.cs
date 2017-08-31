using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _LocallocCnstB117_LocallocCnstB117_
    {
        [OuterLoop]
        [Fact]
        public void _LocallocCnstB117_LocallocCnstB117_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocCnstB117\\LocallocCnstB117.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
