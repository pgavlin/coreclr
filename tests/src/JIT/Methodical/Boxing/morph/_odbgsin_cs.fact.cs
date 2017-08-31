using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_morph__odbgsin_cs__odbgsin_cs_
    {
        [Fact]
        public void _Boxing_morph__odbgsin_cs__odbgsin_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\morph\\_odbgsin_cs\\_odbgsin_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
