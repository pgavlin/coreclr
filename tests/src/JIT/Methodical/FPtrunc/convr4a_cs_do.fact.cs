using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _FPtrunc_convr4a_cs_do_convr4a_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _FPtrunc_convr4a_cs_do_convr4a_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\FPtrunc\\convr4a_cs_do\\convr4a_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
