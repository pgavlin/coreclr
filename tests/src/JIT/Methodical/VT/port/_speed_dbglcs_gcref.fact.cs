using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_port__speed_dbglcs_gcref__speed_dbglcs_gcref_
    {
        [Fact]
        public void _VT_port__speed_dbglcs_gcref__speed_dbglcs_gcref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\port\\_speed_dbglcs_gcref\\_speed_dbglcs_gcref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
