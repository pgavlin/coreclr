using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_vsw_575343_test2_test2_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_575343_test2_test2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\575343\\test2\\test2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
