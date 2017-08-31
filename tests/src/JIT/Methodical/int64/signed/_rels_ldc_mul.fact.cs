using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__rels_ldc_mul__rels_ldc_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_signed__rels_ldc_mul__rels_ldc_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_rels_ldc_mul\\_rels_ldc_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
