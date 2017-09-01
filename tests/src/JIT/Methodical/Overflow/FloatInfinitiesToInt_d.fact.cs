using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Overflow_FloatInfinitiesToInt_d_FloatInfinitiesToInt_d_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatInfinitiesToInt_d_FloatInfinitiesToInt_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatInfinitiesToInt_d\\FloatInfinitiesToInt_d.cmd");
        }
    }
}
