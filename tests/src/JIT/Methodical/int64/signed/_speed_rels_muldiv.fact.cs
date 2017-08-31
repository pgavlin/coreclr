using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__speed_rels_muldiv__speed_rels_muldiv_
    {
        [Fact]
        public void _int64_signed__speed_rels_muldiv__speed_rels_muldiv_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_speed_rels_muldiv\\_speed_rels_muldiv.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
