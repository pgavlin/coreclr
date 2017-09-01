using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ldftn_calli_ldftn_calli_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldftn_calli_ldftn_calli_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldftn_calli\\ldftn_calli.cmd");
        }
    }
}
