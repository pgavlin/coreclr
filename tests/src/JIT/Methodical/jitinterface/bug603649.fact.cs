using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _jitinterface_bug603649_bug603649_
    {
        [OuterLoop]
        [Fact]
        public void _jitinterface_bug603649_bug603649_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\jitinterface\\bug603649\\bug603649.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
