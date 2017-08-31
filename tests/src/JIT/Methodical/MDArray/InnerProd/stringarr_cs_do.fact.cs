using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_InnerProd_stringarr_cs_do_stringarr_cs_do_
    {
        [Fact]
        public void _MDArray_InnerProd_stringarr_cs_do_stringarr_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\stringarr_cs_do\\stringarr_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
