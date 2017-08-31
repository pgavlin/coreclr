using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Arrays_Complex2_Complex2_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_Complex2_Complex2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Arrays\\Complex2\\Complex2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
