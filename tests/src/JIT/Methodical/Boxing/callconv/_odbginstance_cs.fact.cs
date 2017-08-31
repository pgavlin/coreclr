using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_callconv__odbginstance_cs__odbginstance_cs_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_callconv__odbginstance_cs__odbginstance_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\callconv\\_odbginstance_cs\\_odbginstance_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
