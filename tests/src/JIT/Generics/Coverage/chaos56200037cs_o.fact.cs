using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Coverage_chaos56200037cs_o_chaos56200037cs_o_
    {
        [Fact]
        public void _Coverage_chaos56200037cs_o_chaos56200037cs_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Coverage\\chaos56200037cs_o\\chaos56200037cs_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
