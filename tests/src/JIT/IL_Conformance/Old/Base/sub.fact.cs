using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_sub_sub_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_sub_sub_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\sub\\sub.cmd");
        }
    }
}
