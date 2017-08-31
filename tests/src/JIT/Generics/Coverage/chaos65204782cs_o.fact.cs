using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Coverage_chaos65204782cs_o_chaos65204782cs_o_
    {
        [OuterLoop]
        [Fact]
        public void _Coverage_chaos65204782cs_o_chaos65204782cs_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Coverage\\chaos65204782cs_o\\chaos65204782cs_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
