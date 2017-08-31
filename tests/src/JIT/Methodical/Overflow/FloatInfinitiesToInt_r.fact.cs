using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Overflow_FloatInfinitiesToInt_r_FloatInfinitiesToInt_r_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatInfinitiesToInt_r_FloatInfinitiesToInt_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatInfinitiesToInt_r\\FloatInfinitiesToInt_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
