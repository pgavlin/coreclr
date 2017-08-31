using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Coverage_chaos56200037cs_chaos56200037cs_
    {
        [Fact]
        public void _Coverage_chaos56200037cs_chaos56200037cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Coverage\\chaos56200037cs\\chaos56200037cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
