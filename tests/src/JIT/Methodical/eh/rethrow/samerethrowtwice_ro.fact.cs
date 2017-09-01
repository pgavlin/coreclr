using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_rethrow_samerethrowtwice_ro_samerethrowtwice_ro_
    {
        [Fact]
        public void _eh_rethrow_samerethrowtwice_ro_samerethrowtwice_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\samerethrowtwice_ro\\samerethrowtwice_ro.cmd");
        }
    }
}
