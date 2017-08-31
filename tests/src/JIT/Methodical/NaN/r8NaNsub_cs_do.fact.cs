using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_r8NaNsub_cs_do_r8NaNsub_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r8NaNsub_cs_do_r8NaNsub_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r8NaNsub_cs_do\\r8NaNsub_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
