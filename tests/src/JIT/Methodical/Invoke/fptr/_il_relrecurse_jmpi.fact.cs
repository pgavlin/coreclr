using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_relrecurse_jmpi__il_relrecurse_jmpi_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_relrecurse_jmpi__il_relrecurse_jmpi_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relrecurse_jmpi\\_il_relrecurse_jmpi.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
