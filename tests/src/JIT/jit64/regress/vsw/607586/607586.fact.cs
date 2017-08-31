using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _regress_vsw_607586_607586_607586_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_607586_607586_607586_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\607586\\607586\\607586.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
