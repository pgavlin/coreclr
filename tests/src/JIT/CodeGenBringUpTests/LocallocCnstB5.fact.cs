using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _LocallocCnstB5_LocallocCnstB5_
    {
        [OuterLoop]
        [Fact]
        public void _LocallocCnstB5_LocallocCnstB5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LocallocCnstB5\\LocallocCnstB5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
