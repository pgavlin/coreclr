using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Coverage_chaos65204782cs_chaos65204782cs_
    {
        [OuterLoop]
        [Fact]
        public void _Coverage_chaos65204782cs_chaos65204782cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Coverage\\chaos65204782cs\\chaos65204782cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
