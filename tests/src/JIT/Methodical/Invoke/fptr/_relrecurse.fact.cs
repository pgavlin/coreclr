using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Invoke_fptr__relrecurse__relrecurse_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__relrecurse__relrecurse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_relrecurse\\_relrecurse.cmd");
        }
    }
}
