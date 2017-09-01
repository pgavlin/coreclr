using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind05_dynamic_unwind05_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind05_dynamic_unwind05_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind05_dynamic\\unwind05_dynamic.cmd");
        }
    }
}
