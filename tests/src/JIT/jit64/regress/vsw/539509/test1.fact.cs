using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_vsw_539509_test1_test1_
    {
        [Fact]
        public void _regress_vsw_539509_test1_test1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\539509\\test1\\test1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
