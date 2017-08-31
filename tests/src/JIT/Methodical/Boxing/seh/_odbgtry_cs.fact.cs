using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_seh__odbgtry_cs__odbgtry_cs_
    {
        [Fact]
        public void _Boxing_seh__odbgtry_cs__odbgtry_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\seh\\_odbgtry_cs\\_odbgtry_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
