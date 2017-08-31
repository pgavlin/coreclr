using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_functional__orelfibo_cs__orelfibo_cs_
    {
        [Fact]
        public void _Boxing_functional__orelfibo_cs__orelfibo_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\functional\\_orelfibo_cs\\_orelfibo_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
