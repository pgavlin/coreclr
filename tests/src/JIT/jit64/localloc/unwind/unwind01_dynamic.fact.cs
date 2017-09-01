using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind01_dynamic_unwind01_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind01_dynamic_unwind01_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind01_dynamic\\unwind01_dynamic.cmd");
        }
    }
}
