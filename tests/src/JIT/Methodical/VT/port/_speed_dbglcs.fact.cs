using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_port__speed_dbglcs__speed_dbglcs_
    {
        [OuterLoop]
        [Fact]
        public void _VT_port__speed_dbglcs__speed_dbglcs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\port\\_speed_dbglcs\\_speed_dbglcs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
