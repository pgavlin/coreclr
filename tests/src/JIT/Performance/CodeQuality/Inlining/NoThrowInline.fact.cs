using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    public class _CodeQuality_Inlining_NoThrowInline_NoThrowInline_
    {
        [Fact]
        public void _CodeQuality_Inlining_NoThrowInline_NoThrowInline_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Inlining\\NoThrowInline\\NoThrowInline.cmd");
        }
    }
}
