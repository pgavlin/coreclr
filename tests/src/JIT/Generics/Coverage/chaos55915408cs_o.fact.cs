using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Coverage_chaos55915408cs_o_chaos55915408cs_o_
    {
        [Fact]
        public void _Coverage_chaos55915408cs_o_chaos55915408cs_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Coverage\\chaos55915408cs_o\\chaos55915408cs_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
