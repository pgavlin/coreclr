using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Overflow_FloatInfinitiesToInt_do_FloatInfinitiesToInt_do_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatInfinitiesToInt_do_FloatInfinitiesToInt_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatInfinitiesToInt_do\\FloatInfinitiesToInt_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
