using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_seh__dbgtry_cs__dbgtry_cs_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_seh__dbgtry_cs__dbgtry_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\seh\\_dbgtry_cs\\_dbgtry_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
