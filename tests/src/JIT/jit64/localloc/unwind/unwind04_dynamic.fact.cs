using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind04_dynamic_unwind04_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind04_dynamic_unwind04_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind04_dynamic\\unwind04_dynamic.cmd");
        }
    }
}
