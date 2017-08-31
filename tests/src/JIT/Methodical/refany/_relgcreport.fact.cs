using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__relgcreport__relgcreport_
    {
        [Fact]
        public void _refany__relgcreport__relgcreport_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_relgcreport\\_relgcreport.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
