using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_port__rellcs__rellcs_
    {
        [OuterLoop]
        [Fact]
        public void _VT_port__rellcs__rellcs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\port\\_rellcs\\_rellcs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
