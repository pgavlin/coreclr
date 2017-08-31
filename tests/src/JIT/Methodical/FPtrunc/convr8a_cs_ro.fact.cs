using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _FPtrunc_convr8a_cs_ro_convr8a_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _FPtrunc_convr8a_cs_ro_convr8a_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\FPtrunc\\convr8a_cs_ro\\convr8a_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
