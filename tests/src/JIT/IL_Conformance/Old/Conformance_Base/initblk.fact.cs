using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_initblk_initblk_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_initblk_initblk_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\initblk\\initblk.cmd");
        }
    }
}
