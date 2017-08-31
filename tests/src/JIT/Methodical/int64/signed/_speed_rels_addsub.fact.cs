using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__speed_rels_addsub__speed_rels_addsub_
    {
        [OuterLoop]
        [Fact]
        public void _int64_signed__speed_rels_addsub__speed_rels_addsub_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_speed_rels_addsub\\_speed_rels_addsub.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
