using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Arrays_Complex1_Complex1_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_Complex1_Complex1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Arrays\\Complex1\\Complex1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
