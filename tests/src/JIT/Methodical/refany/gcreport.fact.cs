using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany_gcreport_gcreport_
    {
        [Fact]
        public void _refany_gcreport_gcreport_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\gcreport\\gcreport.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
