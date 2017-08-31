using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _LocallocCnstB5001_LocallocCnstB5001_
    {
        [OuterLoop]
        [Fact]
        public void _LocallocCnstB5001_LocallocCnstB5001_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocCnstB5001\\LocallocCnstB5001.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
