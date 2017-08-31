using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_relnative__il_relnative_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_relnative__il_relnative_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_relnative\\_il_relnative.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
