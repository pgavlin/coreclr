using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_dbgnative__il_dbgnative_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_dbgnative__il_dbgnative_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_dbgnative\\_il_dbgnative.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
