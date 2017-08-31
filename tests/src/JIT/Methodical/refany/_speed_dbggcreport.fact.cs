using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__speed_dbggcreport__speed_dbggcreport_
    {
        [Fact]
        public void _refany__speed_dbggcreport__speed_dbggcreport_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_speed_dbggcreport\\_speed_dbggcreport.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
