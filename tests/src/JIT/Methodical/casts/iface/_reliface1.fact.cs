using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_iface__reliface1__reliface1_
    {
        [Fact]
        public void _casts_iface__reliface1__reliface1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\iface\\_reliface1\\_reliface1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
