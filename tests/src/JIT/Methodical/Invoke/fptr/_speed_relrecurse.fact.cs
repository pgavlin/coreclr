using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__speed_relrecurse__speed_relrecurse_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__speed_relrecurse__speed_relrecurse_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_speed_relrecurse\\_speed_relrecurse.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
