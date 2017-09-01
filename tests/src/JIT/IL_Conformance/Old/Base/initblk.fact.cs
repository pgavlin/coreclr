using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_initblk_initblk_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_initblk_initblk_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\initblk\\initblk.cmd");
        }
    }
}
