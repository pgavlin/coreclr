using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__dbgnative__dbgnative_
    {
        [OuterLoop]
        [Fact]
        public void _refany__dbgnative__dbgnative_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_dbgnative\\_dbgnative.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
