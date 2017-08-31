using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__speed_dbgnative__speed_dbgnative_
    {
        [OuterLoop]
        [Fact]
        public void _refany__speed_dbgnative__speed_dbgnative_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_speed_dbgnative\\_speed_dbgnative.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
