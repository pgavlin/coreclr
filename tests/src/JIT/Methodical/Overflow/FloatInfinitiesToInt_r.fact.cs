using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Overflow_FloatInfinitiesToInt_r_FloatInfinitiesToInt_r_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatInfinitiesToInt_r_FloatInfinitiesToInt_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatInfinitiesToInt_r\\FloatInfinitiesToInt_r.cmd");
        }
    }
}
