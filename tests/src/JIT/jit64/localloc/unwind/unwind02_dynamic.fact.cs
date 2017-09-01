using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind02_dynamic_unwind02_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind02_dynamic_unwind02_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind02_dynamic\\unwind02_dynamic.cmd");
        }
    }
}
