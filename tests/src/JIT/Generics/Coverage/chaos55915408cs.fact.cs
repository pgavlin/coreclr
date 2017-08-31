using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Coverage_chaos55915408cs_chaos55915408cs_
    {
        [Fact]
        public void _Coverage_chaos55915408cs_chaos55915408cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Coverage\\chaos55915408cs\\chaos55915408cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
