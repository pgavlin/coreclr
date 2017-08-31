using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_port__speed_rellcs__speed_rellcs_
    {
        [OuterLoop]
        [Fact]
        public void _VT_port__speed_rellcs__speed_rellcs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\port\\_speed_rellcs\\_speed_rellcs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
