using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Overflow_FloatInfinitiesToInt_d_FloatInfinitiesToInt_d_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatInfinitiesToInt_d_FloatInfinitiesToInt_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatInfinitiesToInt_d\\FloatInfinitiesToInt_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
