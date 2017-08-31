using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Coverage_b518440_b518440_
    {
        [OuterLoop]
        [Fact]
        public void _Coverage_b518440_b518440_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Coverage\\b518440\\b518440.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
