using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__dbggcreport__dbggcreport_
    {
        [Fact]
        public void _refany__dbggcreport__dbggcreport_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_dbggcreport\\_dbggcreport.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
