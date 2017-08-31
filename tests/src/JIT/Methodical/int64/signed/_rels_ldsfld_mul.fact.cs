using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__rels_ldsfld_mul__rels_ldsfld_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_signed__rels_ldsfld_mul__rels_ldsfld_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_rels_ldsfld_mul\\_rels_ldsfld_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
