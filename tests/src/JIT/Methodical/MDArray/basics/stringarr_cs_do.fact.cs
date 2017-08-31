using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_basics_stringarr_cs_do_stringarr_cs_do_
    {
        [Fact]
        public void _MDArray_basics_stringarr_cs_do_stringarr_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\basics\\stringarr_cs_do\\stringarr_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
