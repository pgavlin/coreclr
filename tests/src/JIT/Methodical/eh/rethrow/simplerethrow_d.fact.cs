using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_rethrow_simplerethrow_d_simplerethrow_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_simplerethrow_d_simplerethrow_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\simplerethrow_d\\simplerethrow_d.cmd");
        }
    }
}
