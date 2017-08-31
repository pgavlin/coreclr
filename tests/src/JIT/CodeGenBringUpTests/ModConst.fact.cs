using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _ModConst_ModConst_
    {
        [Fact]
        public void _ModConst_ModConst_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ModConst\\ModConst.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
