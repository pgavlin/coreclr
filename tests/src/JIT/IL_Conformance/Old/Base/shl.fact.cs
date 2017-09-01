using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_shl_shl_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_shl_shl_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\shl\\shl.cmd");
        }
    }
}
