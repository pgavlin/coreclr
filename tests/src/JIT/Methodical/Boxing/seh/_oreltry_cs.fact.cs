using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_seh__oreltry_cs__oreltry_cs_
    {
        [Fact]
        public void _Boxing_seh__oreltry_cs__oreltry_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\seh\\_oreltry_cs\\_oreltry_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
