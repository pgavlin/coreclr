using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind03_dynamic_unwind03_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind03_dynamic_unwind03_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind03_dynamic\\unwind03_dynamic.cmd");
        }
    }
}
