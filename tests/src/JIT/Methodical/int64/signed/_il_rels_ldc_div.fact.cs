using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__il_rels_ldc_div__il_rels_ldc_div_
    {
        [Fact]
        public void _int64_signed__il_rels_ldc_div__il_rels_ldc_div_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_il_rels_ldc_div\\_il_rels_ldc_div.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
