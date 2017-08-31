using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__rels_muldiv__rels_muldiv_
    {
        [Fact]
        public void _int64_signed__rels_muldiv__rels_muldiv_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_rels_muldiv\\_rels_muldiv.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
