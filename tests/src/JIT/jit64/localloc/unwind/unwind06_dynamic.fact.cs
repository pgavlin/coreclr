using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind06_dynamic_unwind06_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind06_dynamic_unwind06_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind06_dynamic\\unwind06_dynamic.cmd");
        }
    }
}
