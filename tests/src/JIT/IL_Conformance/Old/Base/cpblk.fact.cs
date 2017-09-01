using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_cpblk_cpblk_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_cpblk_cpblk_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\cpblk\\cpblk.cmd");
        }
    }
}
