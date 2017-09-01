using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_directed_heap_ovf_heap_ovf_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_heap_ovf_heap_ovf_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\heap_ovf\\heap_ovf.cmd");
        }
    }
}
