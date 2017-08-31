using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Coverage_b39946_b39946_
    {
        [Fact]
        public void _Coverage_b39946_b39946_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Coverage\\b39946\\b39946.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
