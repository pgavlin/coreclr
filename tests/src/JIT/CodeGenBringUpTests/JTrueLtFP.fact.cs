using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _JTrueLtFP_JTrueLtFP_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueLtFP_JTrueLtFP_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueLtFP\\JTrueLtFP.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
