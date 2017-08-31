using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_Inlining_NoThrowInline_NoThrowInline_
    {
        [Fact]
        public void _CodeQuality_Inlining_NoThrowInline_NoThrowInline_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Inlining\\NoThrowInline\\NoThrowInline.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
