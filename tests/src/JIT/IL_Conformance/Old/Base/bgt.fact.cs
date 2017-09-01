using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_bgt_bgt_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_bgt_bgt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\bgt\\bgt.cmd");
        }
    }
}
