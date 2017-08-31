using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _UModConst_UModConst_
    {
        [Fact]
        public void _UModConst_UModConst_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\UModConst\\UModConst.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
