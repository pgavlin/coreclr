using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Arrays_Simple1_Simple1_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_Simple1_Simple1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Arrays\\Simple1\\Simple1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
