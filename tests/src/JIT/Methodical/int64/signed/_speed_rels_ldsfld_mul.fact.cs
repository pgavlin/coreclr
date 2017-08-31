using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__speed_rels_ldsfld_mul__speed_rels_ldsfld_mul_
    {
        [OuterLoop]
        [Fact]
        public void _int64_signed__speed_rels_ldsfld_mul__speed_rels_ldsfld_mul_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_speed_rels_ldsfld_mul\\_speed_rels_ldsfld_mul.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
