using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_fptr__il_dbgrecurse_jmpi__il_dbgrecurse_jmpi_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_dbgrecurse_jmpi__il_dbgrecurse_jmpi_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_dbgrecurse_jmpi\\_il_dbgrecurse_jmpi.cmd");
        }
    }
}
