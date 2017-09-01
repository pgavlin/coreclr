using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_cpblk_cpblk_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_cpblk_cpblk_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\cpblk\\cpblk.cmd");
        }
    }
}
