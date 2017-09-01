using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Overflow_FloatInfinitiesToInt_ro_FloatInfinitiesToInt_ro_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatInfinitiesToInt_ro_FloatInfinitiesToInt_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatInfinitiesToInt_ro\\FloatInfinitiesToInt_ro.cmd");
        }
    }
}
