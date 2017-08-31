using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_directed_heap_ovf_heap_ovf_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_heap_ovf_heap_ovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\heap_ovf\\heap_ovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
