using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_rethrow_simplerethrow_r_simplerethrow_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_simplerethrow_r_simplerethrow_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\simplerethrow_r\\simplerethrow_r.cmd");
        }
    }
}
