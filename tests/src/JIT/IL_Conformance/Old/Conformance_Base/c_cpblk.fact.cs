using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_c_cpblk_c_cpblk_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_c_cpblk_c_cpblk_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\c_cpblk\\c_cpblk.cmd");
        }
    }
}
