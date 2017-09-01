using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_rethrow_simplerethrow_do_simplerethrow_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_simplerethrow_do_simplerethrow_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\simplerethrow_do\\simplerethrow_do.cmd");
        }
    }
}
