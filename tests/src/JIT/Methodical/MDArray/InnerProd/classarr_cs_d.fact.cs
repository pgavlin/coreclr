using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_InnerProd_classarr_cs_d_classarr_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_classarr_cs_d_classarr_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\classarr_cs_d\\classarr_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
