using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_iface__speed_dbgiface1__speed_dbgiface1_
    {
        [Fact]
        public void _casts_iface__speed_dbgiface1__speed_dbgiface1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\iface\\_speed_dbgiface1\\_speed_dbgiface1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
