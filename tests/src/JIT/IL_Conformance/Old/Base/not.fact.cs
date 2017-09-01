using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_not_not_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_not_not_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\not\\not.cmd");
        }
    }
}
