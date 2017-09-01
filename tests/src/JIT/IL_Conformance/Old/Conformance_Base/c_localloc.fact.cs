using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_c_localloc_c_localloc_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_c_localloc_c_localloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\c_localloc\\c_localloc.cmd");
        }
    }
}
