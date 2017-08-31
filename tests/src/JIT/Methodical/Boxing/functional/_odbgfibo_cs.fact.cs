using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_functional__odbgfibo_cs__odbgfibo_cs_
    {
        [Fact]
        public void _Boxing_functional__odbgfibo_cs__odbgfibo_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\functional\\_odbgfibo_cs\\_odbgfibo_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
