using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__reljumper__reljumper_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__reljumper__reljumper_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_reljumper\\_reljumper.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
