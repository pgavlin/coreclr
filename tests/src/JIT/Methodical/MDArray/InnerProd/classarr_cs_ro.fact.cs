using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_InnerProd_classarr_cs_ro_classarr_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_classarr_cs_ro_classarr_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\classarr_cs_ro\\classarr_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
