using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_fptr__il_relrecurse_jmpi__il_relrecurse_jmpi_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_relrecurse_jmpi__il_relrecurse_jmpi_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relrecurse_jmpi\\_il_relrecurse_jmpi.cmd");
        }
    }
}
