using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__speed_relgcreport__speed_relgcreport_
    {
        [Fact]
        public void _refany__speed_relgcreport__speed_relgcreport_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_speed_relgcreport\\_speed_relgcreport.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
