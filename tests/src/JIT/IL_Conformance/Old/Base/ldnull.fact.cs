using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ldnull_ldnull_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldnull_ldnull_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldnull\\ldnull.cmd");
        }
    }
}
