using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__speed_relnative__speed_relnative_
    {
        [OuterLoop]
        [Fact]
        public void _refany__speed_relnative__speed_relnative_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_speed_relnative\\_speed_relnative.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
