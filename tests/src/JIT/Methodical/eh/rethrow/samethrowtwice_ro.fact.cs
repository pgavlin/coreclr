using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_rethrow_samethrowtwice_ro_samethrowtwice_ro_
    {
        [Fact]
        public void _eh_rethrow_samethrowtwice_ro_samethrowtwice_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\samethrowtwice_ro\\samethrowtwice_ro.cmd");
        }
    }
}
