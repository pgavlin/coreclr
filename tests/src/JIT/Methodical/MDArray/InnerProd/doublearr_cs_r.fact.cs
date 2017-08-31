using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_InnerProd_doublearr_cs_r_doublearr_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_doublearr_cs_r_doublearr_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\doublearr_cs_r\\doublearr_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
