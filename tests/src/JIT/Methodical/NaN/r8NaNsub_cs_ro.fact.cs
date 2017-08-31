using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_r8NaNsub_cs_ro_r8NaNsub_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r8NaNsub_cs_ro_r8NaNsub_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r8NaNsub_cs_ro\\r8NaNsub_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
