using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_InnerProd_doublearr_cs_d_doublearr_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_doublearr_cs_d_doublearr_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\doublearr_cs_d\\doublearr_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
