using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Overflow_FloatInfinitiesToInt_do_FloatInfinitiesToInt_do_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatInfinitiesToInt_do_FloatInfinitiesToInt_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatInfinitiesToInt_do\\FloatInfinitiesToInt_do.cmd");
        }
    }
}
