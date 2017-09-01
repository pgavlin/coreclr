using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _Arrays_Complex2_Complex2_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_Complex2_Complex2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\Arrays\\Complex2\\Complex2.cmd");
        }
    }
}
