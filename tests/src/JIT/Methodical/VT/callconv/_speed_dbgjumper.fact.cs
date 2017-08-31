using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_callconv__speed_dbgjumper__speed_dbgjumper_
    {
        [Fact]
        public void _VT_callconv__speed_dbgjumper__speed_dbgjumper_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_speed_dbgjumper\\_speed_dbgjumper.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
