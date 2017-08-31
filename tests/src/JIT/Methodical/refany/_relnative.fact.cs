using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__relnative__relnative_
    {
        [OuterLoop]
        [Fact]
        public void _refany__relnative__relnative_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_relnative\\_relnative.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
