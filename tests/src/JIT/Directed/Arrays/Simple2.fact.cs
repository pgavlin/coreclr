using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Arrays_Simple2_Simple2_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_Simple2_Simple2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Arrays\\Simple2\\Simple2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
