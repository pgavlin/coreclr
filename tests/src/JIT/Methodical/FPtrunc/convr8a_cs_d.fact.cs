using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _FPtrunc_convr8a_cs_d_convr8a_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _FPtrunc_convr8a_cs_d_convr8a_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\FPtrunc\\convr8a_cs_d\\convr8a_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
