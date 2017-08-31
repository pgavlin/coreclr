using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Coverage_b433189_b433189_
    {
        [OuterLoop]
        [Fact]
        public void _Coverage_b433189_b433189_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Coverage\\b433189\\b433189.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
