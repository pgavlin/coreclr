using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_rethrow_simplerethrow_ro_simplerethrow_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_simplerethrow_ro_simplerethrow_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\simplerethrow_ro\\simplerethrow_ro.cmd");
        }
    }
}
