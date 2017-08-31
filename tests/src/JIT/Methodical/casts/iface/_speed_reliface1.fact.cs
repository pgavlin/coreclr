using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_iface__speed_reliface1__speed_reliface1_
    {
        [Fact]
        public void _casts_iface__speed_reliface1__speed_reliface1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\iface\\_speed_reliface1\\_speed_reliface1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
