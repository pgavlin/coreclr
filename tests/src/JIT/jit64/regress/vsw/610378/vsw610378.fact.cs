using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_vsw_610378_vsw610378_vsw610378_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_610378_vsw610378_vsw610378_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\610378\\vsw610378\\vsw610378.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
