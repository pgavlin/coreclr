using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Overflow_FloatInfinitiesToInt_ro_FloatInfinitiesToInt_ro_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatInfinitiesToInt_ro_FloatInfinitiesToInt_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatInfinitiesToInt_ro\\FloatInfinitiesToInt_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
